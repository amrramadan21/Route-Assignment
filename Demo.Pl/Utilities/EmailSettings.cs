using System.Net;
using System.Net.Mail;

namespace Demo.Pl.Utilities
{
    public static class EmailSettings
    {
        public static bool SendEmail(Email email)
        {

            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("ammareldesouki130@gmail.com", "Ammar@20220305");
                client.Send("ammareldesouki130@gmail.com", email.To, email.Subject, email.Body);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
