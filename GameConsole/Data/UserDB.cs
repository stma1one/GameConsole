using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace GameConsole.Data
{
    internal class UserDB
    {
        public static List<User> UserList = new List<User>();
        public UserDB(){}
        public static User Login(string UserName, string pass)
        {
            return UserList.FirstOrDefault(u =>  u.UserName ==  UserName && u.Password == pass);
        }

        public static void Register(string name, string userName, string pass)
        {
            Console.ReadKey();
            var exist = UserList.FirstOrDefault(user => user.UserName == name);
            if (exist == null && name != null && name != "" && userName != null && userName != "" && pass != null && pass != "")
                UserList.Add(new User(name, userName, pass));
            else
                throw new Exception("There is such a user / there was a problem");
        }

        public static void Update(User u)
        {
            var user = UserList.FirstOrDefault(User => User.UserName == u.UserName);
            if(user != null && user.Name != null && user.Name != "" && user.UserName != null && user.UserName != "")
            {
                user.UserName = u.UserName;
                user.Name = u.Name;
                //user.Password = u.Password;
            }
            else
            {
                throw new InvalidOperationException("no such user exists");
            }
        }

    }
}
