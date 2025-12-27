using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace GameConsole.Models;
using GameConsole.Pages;
using GameConsole.Models;



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
            string name;
            string pass;
            string userName;
            bool toLogin = false;
            while (true)
            {
                
                while (true)
                {
                    base.Show();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter your name: ");
                    Console.ResetColor();
                    name = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter your user name: ");
                    Console.ResetColor();
                    userName = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Enter your password: ");
                    Console.ResetColor();
                    pass = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Confirm your password: ");
                    Console.ResetColor();
                    string pass2 = Console.ReadLine();
                    if (pass == pass2)
                        break;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("The passwords are not the same. Try again.");
                    Console.ReadKey();
                    Console.ResetColor();
                }
                try{
                    UserDB.Register(name, userName, pass); 
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("A user with that username already exists. Try again or press \"l\" to login");

                    string answer = Console.ReadLine();
                    if (answer == "l" || answer == "L")
                    {
                        toLogin = true;
                        LoginScreen login = new LoginScreen();
                        login.Show();
                        break;
                    }


                    Console.ResetColor();
                }
            }
            if (!toLogin)
            {
                

                User user = new User(name, userName, password);
                ConsoleGame.user = user;

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
