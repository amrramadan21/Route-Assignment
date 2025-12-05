using DomainLayer.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.IIS;
using Shared.ErrorModels;
using System.Net.Http;
using System.Text.Json;

namespace Talabat.CustomMiddleWares
{
    public class CustomExceptionHandlerMiddleWare
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomExceptionHandlerMiddleWare> _logger;

        public CustomExceptionHandlerMiddleWare(RequestDelegate Next,ILogger<CustomExceptionHandlerMiddleWare> logger)
        {
            _next = Next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext httpcontext)
        {
            try
            {
                await _next.Invoke(httpcontext);
                await HandleNotFoundEndPointAsync(httpcontext);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Somthing Went Wrong.");
                await HandleExceptionAsync(httpcontext, ex);
            }
        }

        private static async Task HandleExceptionAsync(HttpContext httpcontext, Exception ex)
        {

            //Create Response Object
            var response = new ErrorToReturn()
            {
                ErrorMessage = ex.Message
            };
            //Set Status Code For Response
            httpcontext.Response.StatusCode = ex switch
            {
                NotFoundException => StatusCodes.Status404NotFound,
                UnauthorizedException => StatusCodes.Status401Unauthorized,
                BadRequestException badRequestEx => GetBadRequestErrors(badRequestEx, response),
                _ => StatusCodes.Status500InternalServerError
            };
            response.StatusCode = httpcontext.Response.StatusCode;


            //Set Content Type For Response
            //httpcontext.Response.ContentType = "application/json";

           

            //Write Response As Json
            await httpcontext.Response.WriteAsJsonAsync(response);
        }

        private static int GetBadRequestErrors(BadRequestException badRequestException,ErrorToReturn response)
        {
            response.Errors = badRequestException.Errors;
            return StatusCodes.Status400BadRequest;
        }

        private static async Task HandleNotFoundEndPointAsync(HttpContext httpcontext)
        {
            if (httpcontext.Response.StatusCode == StatusCodes.Status404NotFound)
            {

                var response = new ErrorToReturn()
                {
                    StatusCode = httpcontext.Response.StatusCode,
                    ErrorMessage = $"End Point {httpcontext.Request.Path} is Not Found"
                };
                await httpcontext.Response.WriteAsJsonAsync(response);
            }
        }
    }
}
