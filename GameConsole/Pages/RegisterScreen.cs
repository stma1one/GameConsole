using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameConsole.Models;

namespace GameConsole.Pages
{
    internal class RegisterScreen:Screen
    {
        private string name;
        private string userName;
        private string password;

        public RegisterScreen() : base("Registery screen") { }

        public override void Show()
        {
            while (true)
            {
                string name;
                string pass;
                string userName;
                while (true)
                {
                    base.Show();
                    Console.WriteLine("Enter your name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter your user name: ");
                    userName = Console.ReadLine();
                    Console.WriteLine("Enter your password: ");
                    pass = Console.ReadLine();
                    Console.WriteLine("Confirm your password: ");
                    string pass2 = Console.ReadLine();
                    if (pass == pass2)
                        break;
                    Console.WriteLine("The passwords are not the same. Try again.");
                }
                try{
                    UserDB.Register(name, userName, pass);
                    break;
                }
                catch
                {
                    Console.WriteLine("A user with that username already exists. Try again.");
                }
            }
        }
    }
}
