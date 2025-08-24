using Assignment03_OOP03.Interface_Q1;
using Assignment03_OOP03.Interface_Q2;
using Assignment03_OOP03.Interface_Q3;

namespace Assignment03_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Q1
            //What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class
            #endregion

            #region Q2
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private


            #endregion

            #region Q3
            //Can an interface contain fields in C#?
            //b) No

            #endregion

            #region Q4
            //In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces


            #endregion

            #region Q5
            //Which keyword is used to implement an interface in a class in C#?
            //d) implements

            #endregion

            #region Q6
            //Can an interface contain static methods in C#?
            //a) Yes

            #endregion

            #region Q7
            //In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public

            #endregion

            #region Q8
            //What is the purpose of an explicit interface implementation in C#?
            //a) To hide the interface members from outside access

            #endregion

            #region Q9
            //In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors


            #endregion

            #region Q10
            //How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas

            #endregion
            #endregion

            #region Part02

            #region Q1

            //ICircle circle = new Circle(5);
            //IRectangle rectangle = new Rectangle(4,6);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();

            #endregion

            #region Q2

            //IAuthenticationService authService = new BasicAuthenticationService();

            //Console.Write("Enter username: ");
            //string username = Console.ReadLine()!;

            //Console.Write("Enter password: ");
            //string password = Console.ReadLine()!;

            //Console.Write("Enter role: ");
            //string role = Console.ReadLine()!;


            //if (authService.AuthenticateUser(username, password))
            //{
            //    Console.WriteLine("User authenticated successfully.");


            //    if (authService.AuthorizeUser(username, role))
            //    {
            //        Console.WriteLine($"User authorized as {role}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"User not authorized for role {role}.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed.");
            //}

            #endregion

            #region Q3

            //Console.WriteLine("Choose Notification Type : ");
            //Console.WriteLine("1.Email");
            //Console.WriteLine("2.SMS");
            //Console.WriteLine("3.Push Notification");

            //Console.WriteLine("Enter Choice (1-3): ");
            //string? choice = Console.ReadLine();

            //Console.WriteLine("Enter Recipient Name: ");
            //string? rec = Console.ReadLine();

            //Console.WriteLine("Enter Your Message: ");
            //string? mes = Console.ReadLine();

            //INotificationService? notificationService = null;

            //switch (choice)
            //{
            //    case "1":
            //        notificationService = new EmailNotificationService();
            //        break;
            //    case "2":
            //        notificationService = new SmsNotificationService();
            //        break;
            //    case "3":
            //        notificationService = new PushNotificationService();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Choice");
            //        return;

            //}

            //notificationService.SendNotification(rec ?? "Unknown", mes ?? "No message");




            #endregion


            #endregion


        }
    }
}
