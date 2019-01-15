using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
    public class CheckInput
    {
        public static bool CheckNamePsw(string userName)
        {
            return (userName.Count() < 5 && userName.Count() > 8);

        }
        public static bool CheckUniqueUserName(string userName)
        {
            
            List<User> users = DatabaseAccess.users;
            foreach (User item in users)
            {
                if (item.UserName == userName)
                    return true;
            }
            return false;
        }

        public static bool IsYesOrNo()
        {
            String input = Console.ReadLine();
            while (input != "Y" && input != "y" && input != "N" && input != "n")
            {
                Console.WriteLine("Please type \"Y\" OR \"N\"");
                input = Console.ReadLine();
            }
            return( input=="Y" || input=="y");
        }

    }
}
