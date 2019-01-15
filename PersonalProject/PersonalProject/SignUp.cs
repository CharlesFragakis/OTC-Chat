using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    public class SignUp
    {
        public static void NewUser()
        {
            string username;
            string psw;
            do
            {
                Console.WriteLine("Please type a user name. (Between 5 and 8 characters");
                Console.WriteLine("User name: ");
                username = Console.ReadLine();
            } while (CheckInput.CheckNamePsw(username));
            do
            {
                Console.WriteLine("Please type a password. (Between 5 and 8 characters");
                Console.WriteLine("Pasword: ");
                psw = Console.ReadLine();
            } while (CheckInput.CheckNamePsw(psw));

        }
    }
}
