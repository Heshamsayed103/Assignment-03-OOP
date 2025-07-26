using Assignment_03_OOP.Class_Q1;
using Assignment_03_OOP.Classes_Q2;
using Assignment_03_OOP.Classes_Q3;
using Assignment_03_OOP.Interfaces;
using Assignment_03_OOP.Interfaces_Q2;
using Assignment_03_OOP.Interfaces_Q3;

namespace Assignment_03_OOP
{
    internal class Program
    {
        static void Main()
        {
            //========================= PART 01 ====================================//

            #region Question 1:
            //
            //what is the primary purpose of an interface in C#?

            //a) To provide a way to implement multiple inheritance 
            #endregion

            #region Question 2:
            //  Which of the following is NOT a valid access modifier for interface members in C#?

            //a) private

            #endregion

            #region Question 3:
            // Can an interface contain fields in C#?

            //b) No 
            #endregion

            #region Question 4:
            //In C#, can an interface inherit from another interface?

            // b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Question 5:
            // Which keyword is used to implement an interface in a class in C#?

            // d) implements 
            #endregion

            #region Question 6 :
            // Can an interface contain static methods in C#?

            //  a) Yes 
            #endregion

            #region Question 7 :
            //  In C#, can an interface have explicit access modifiers for its members?

            //  b) No, all members are implicitly public

            #endregion

            #region Quesiton 8 :
            //  What is the purpose of an explicit interface implementation in C#?

            // a) To hide the interface members from outside access 
            #endregion

            #region Quesiton 9 :
            //  In C#, can an interface have a constructor?

            // b) No, interfaces cannot have constructors

            #endregion

            #region Question 10 :
            // How can a C# class implement multiple interfaces?

            // c) By separating interface names with commas 
            #endregion


            //================================PART 02 ===============================//

            #region Question 01

            //ICircle circle = new Circle(5);
            //circle.DisplayShapeInfo();

            //IRectangle rectangle = new Rectangle(4, 6);
            //rectangle.DisplayShapeInfo(); 

            #endregion

            #region Question 02


            //IAuthenticationService authService = new BasicAuthenticationService();


            //string username = "Hesham1";
            //string password = "admin5838"
            //string role = "Admin";

            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //Console.WriteLine($"Authentication for {username}: {isAuthenticated}");

            //bool isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"Authorization for {username} as {role}: {isAuthorized}");

            //Console.WriteLine();


            //username = "hesham";
            //password = "AboGhaith";
            //role = "Admin";

            //isAuthenticated = authService.AuthenticateUser(username, password);
            //Console.WriteLine($"Authentication for {username}: {isAuthenticated}");

            //isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"Authorization for {username} as {role}: {isAuthorized}"); 
            #endregion

            #region Question 03
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();


            //emailService.SendNotification("HeshamSayed5830.com", "Welcome via Email!");
            //smsService.SendNotification("+201125515415", "Welcome via SMS!");
            //pushService.SendNotification("User5838", "Welcome via Push Notification!");

            #endregion


        }











    }
    }

