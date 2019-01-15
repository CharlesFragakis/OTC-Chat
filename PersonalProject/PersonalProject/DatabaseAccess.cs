using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalProject
{
   public static class DatabaseAccess
    {
        public static List<User> users = new List<User>();

        public static void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
