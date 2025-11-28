using Demo.DAL.Models.IdentityModels;
using Demo.Pl.Utilities;
using Demo.Pl.ViewModels.IdentityViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Pl.Controllers
{
    public class AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager) : Controller
    {

        #region Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            var userToAdd = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };
            var result = _userManager.CreateAsync(userToAdd, model.Password).Result;
            if (result.Succeeded) return RedirectToAction("Login");
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

        }

        #endregion

        #region Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            // Use FindByNameAsync only if you login with username
            // If you login with email, change to FindByEmailAsync
            var user = _userManager.FindByEmailAsync(model.Email).Result;

            if (user is not null)
            {
                var isValid = _userManager.CheckPasswordAsync(user, model.Password).Result;
                if (isValid)
                {
                    var result = _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false).Result;
                    if (result.IsNotAllowed) ModelState.AddModelError(string.Empty, "Your Account Is Not Allowed");
                    if (result.IsLockedOut) ModelState.AddModelError(string.Empty, "Your Account Is Locked"); // fixed typo
                    if (result.Succeeded) return RedirectToAction(nameof(HomeController.Index), "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid Login"); // password wrong
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid Login"); // user not found
            }

            return View(model); // return model back to view
        }
        #endregion
        #region Log Out

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction(nameof(Login));
        }
        #endregion

        #region Forget Password
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SendResetPasswordLink(ForgetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.FindByEmailAsync(model.Email).Result;
                if (user is not null)
                {
                    //Create Link 
                    var token = _userManager.GeneratePasswordResetTokenAsync(user).Result;
                    var resetPasswordLink = Url.Action("ResetPasswordLink", "Account", new { email = model.Email, token }, Request.Scheme);


                    //create Email
                    var mail = new Email()
                    {
                        To = model.Email,
                        Subject = "Reset Your Password",
                        Body = resetPasswordLink //ToDo
                    };

                    //Send Email
                    var res = EmailSettings.SendEmail(mail);
                    if (res) return RedirectToAction("CheckYourInbox");
                }

            }
            ModelState.AddModelError(string.Empty, "Invalid Operations");
            return View(nameof(ForgetPassword), model);
        }

        #endregion
        #region Check Your Inbox
        [HttpGet]
        public IActionResult CheckYourInbox()
        {
            return View();
        }

        #endregion

        #region Reset Password
        [HttpGet]
        public IActionResult ResetPasswordLink(string email, string token)
        {
            TempData["email"] = email;
            TempData["token"] = token;
            return View();
        }

        [HttpPost]
        public IActionResult ResetPasswordLink(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var email = TempData["email"] as string;
            var token = TempData["token"] as string;

            var user = _userManager.FindByEmailAsync(email).Result;
            if (user is null)
            {
                var res = _userManager.ResetPasswordAsync(user, token, model.Password).Result;
                if (res.Succeeded) return RedirectToAction(nameof(Login));
                else
                {
                    foreach (var error in res.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);

        }

        #endregion
    }
}
