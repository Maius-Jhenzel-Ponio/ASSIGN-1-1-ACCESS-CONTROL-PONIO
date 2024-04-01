using System.ComponentModel.Design;

namespace ACCESS_CONTROL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string RightUsername = "Admin";
            string RightPassword = "Admin1234!";

            int attempt = 0;

            do
            {
                Console.WriteLine("Enter your Username: ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter your Password: ");
                string password = Console.ReadLine();

                if (username == RightUsername && password == RightPassword)
                {
                    Console.WriteLine("Login was Succesful!");
                    return;
                }
                else
                {
                    Console.WriteLine("Login Failed");
                    attempt++;
           
                }

            } while( attempt != 3 );   

            Console.WriteLine("You have used all your attempts!");
            Console.WriteLine("Access Denied!");
       
        }
    }
}
