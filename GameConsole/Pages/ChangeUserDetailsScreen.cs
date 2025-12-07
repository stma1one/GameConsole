using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class ChangeUserDetailsScreen:Screen
    {
        public ChangeUserDetailsScreen():base("Change User Details Screen") { }

        public override void Show()
        {
            while (true) {
                base.Show();
                CenterText("Enter the details below:");
                //Console.ReadKey();
                Console.WriteLine("User name: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Password: ");
                string pass = Console.ReadLine();
                User user = new User(name, userName, pass);
                try {
                    UserDB.Update(user);
                    break;
                }
                catch
                {
                    Console.WriteLine("No such user. Try again.");
                }
            }

        }
    }
}
