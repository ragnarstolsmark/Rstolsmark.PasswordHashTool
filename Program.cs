using System;
using static Rstolsmark.PasswordHashLib.PasswordHasher;
namespace Rstolsmark.PasswordHashTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0){
                Console.WriteLine("\nUsage:");
                Console.WriteLine("To generate a salted hashed password:");
                Console.WriteLine("passwordhasher <password>");
                return;
            }
            Console.WriteLine(HashPassword(args[0]));
        }
    }
}
