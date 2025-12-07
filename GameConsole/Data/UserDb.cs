using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Data
{
    internal class UserDb
    {
        private static List<User> users;

        public UserDb()
        {
            users = new List<User>();
        }
       
        public static User RegisterUser(string username, string name, string password)
        {

            
            User newUser = new User(username, name, password);
            users.Add(newUser);
            return newUser;
        }

        public static User Login(string username, string password)
        {
            return  users.SingleOrDefault(user=>user.Username == username && user.Password == password);
            //foreach (User user in users)
            //{
              //  if (user.Username == username && user.Password == password)
                //{
                  //  return user;
                //}
            //}
            //return null;
        }

        ///פעולה המקבלת משתמש מוצאת אותו במערכת ומעדכת את פרטיו
        //אם לא קיים מחזיר חריגה
        public static void Update(User user)
        {
            
            //מצא את היוזר מהDB אם לא קיים יוזחר EXCEPTION
            //ואם קיים תעדכן אותו

            User u= users.Single(x=>x.Username==user.Username);
                   
                    u.Name = user.Name;
                    u.Password = user.Password;
                    return;
                
            }

            
        }
    }
}

