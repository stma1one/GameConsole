using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Models;


namespace GameConsole.Pages
{
    internal class LoginScreen: Screen
    {
        private string name;
        private string userName;
        private string password;

        public LoginScreen():base("Login screen"){ }

        public override void Show()
        {
            User user = null;
            Boolean toRegister = false;
            base.Show();
            while (true)
            {
                CenterText("Enter the details below:");
                //Console.ReadKey();
                Console.WriteLine("User name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Password: ");
                string pass = Console.ReadLine();
                user = UserDB.Login(userName, password);
                if (user != null)
                {
                    Console.WriteLine("The user has been successfully logged in");
                    ConsoleGame.user = user;
                    break;
                }

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Error: something wrong, press anything try again or press \"R\" to register.");
                Console.ResetColor();
                var k = Console.ReadKey();
                string l = k.ToString();
                if (l == "r" || l == "R")
                {
                    Console.WriteLine("register now");
                    RegisterScreen register = new RegisterScreen();
                    register.Show();
                    toRegister = true;
                    break;
                }
            }

            if (!toRegister) { 
                AfterLoginMenu afterLoginMenu = new AfterLoginMenu();
                afterLoginMenu.Show();
            }
        }

    }
}
