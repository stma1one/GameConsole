using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
namespace GameConsole.Pages
{
    internal class ChangePasswordScreen:Screen
    {

        public ChangePasswordScreen() : base("Change Password Screen") { }

        public override void Show()
        {
            while (true)
            {

                Console.WriteLine("Enter the new password: ");
                string pass = Console.ReadLine();
                if (pass == null || pass == "")
                {
                    Console.WriteLine("You have to enter somthing.");
                    continue;
                }
                
                try
                {
                    User temp = new User(ConsoleGame.user.Name, ConsoleGame.user.UserName, pass);
                    UserDB.Update(temp);
                    break;
                }
                catch
                {
                    Console.WriteLine("Error: No such user.");
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("The password was changed correctly. Press any key to continue.");
            Console.ReadKey();
            Console.ResetColor();
            Screen next = new AfterLoginMenu();
            next.Show();

        }

    }
}
