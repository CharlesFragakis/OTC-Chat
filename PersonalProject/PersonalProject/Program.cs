using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Are you a new user?(Y/N)");
            if (CheckInput.IsYesOrNo())
            {
                SignUp.NewUser();
            }
            
        }
    }
}
