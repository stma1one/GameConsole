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
            
            while (true)
            {
                Console.Clear();
                base.Show();
                CenterText("Enter the details below:");
                //Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("User name: ");
                Console.ResetColor();
                string name = Console.ReadLine();
                

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Password: ");
                Console.ResetColor();
                string pass = Console.ReadLine();
                user = UserDB.Login(name, pass);

                if (user != null)
                {
                    Console.WriteLine("The user has been successfully logged in");
                    ConsoleGame.user = user;
                    break;
                }

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Error: something wrong, press anything try again or press \"R\" to register.");
                Console.ResetColor();
                //var k = Console.ReadKey();
                //string l = k.ToString();
                string answer = Console.ReadLine();


                if (answer == "r" || answer == "R")
                {
                    RegisterScreen register = new RegisterScreen();
                    register.Show();
                    toRegister = true;
                    break;
                }
            }

            if (!toRegister) {
                // מוסיפים נתונים לרשימת התוצאות כדי לדמות מסד נתונים אמיתי ולאפשר צפייה בהיסטוריית המשחקים
                ConsoleGame.user.AllScores.Add(new HighScore("FluffyBird", 90));
                ConsoleGame.user.AllScores.Add(new HighScore("FluffyBird", 30));
                ConsoleGame.user.AllScores.Add(new HighScore("PacMan", 60));
                ConsoleGame.user.AllScores.Add(new HighScore("FluffyBird", 40));
                ConsoleGame.user.AllScores.Add(new HighScore("PacMan", 20));
                ConsoleGame.user.AllScores.Add(new HighScore("Tetris", 50));
                ConsoleGame.user.AllScores.Add(new HighScore("Tetris", 100));

                AfterLoginMenu afterLoginMenu = new AfterLoginMenu();
                afterLoginMenu.Show();
            }
        }

    }
}
