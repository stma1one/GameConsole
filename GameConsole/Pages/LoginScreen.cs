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

            base.Show();
            while (true)
            {
                CenterText("Enter the details below:");
                //Console.ReadKey();
                Console.WriteLine("User name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Password: ");
                string pass = Console.ReadLine();
                user = UserDB.login(userName, password);
                if (user != null)
                {
                    Console.WriteLine("The user has been successfully logged in");
                    break;
                }
                Console.WriteLine("Error: Enter your user details again.");
            }
           

            GameMenu gamesScreen = new GameMenu();
            gamesScreen.Show();

        }

    }
}
