using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class ProgramClass
    {
        static void Main()
        {
            var emailRegex = new Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
            var unameRegex = new Regex("^[a-zA-Z][a-zA-Z0-9._-]{0,}[a-zA-Z0-9_]$");

            Console.Write("Enter email: ");
            string email = Console.ReadLine()!;
            
            Console.Write("Enter username: ");
            string uname = Console.ReadLine()!;

            if (emailRegex.IsMatch(email))
            {
                Console.WriteLine("Valid Email");
            } 
            else
            {
                Console.WriteLine("Bad Email");
            }

            if (unameRegex.IsMatch(uname))
            {
                Console.WriteLine("Valid Username");
            }
            else
            {
                Console.WriteLine("Bad Username");
            }
        }
    
    }
}
