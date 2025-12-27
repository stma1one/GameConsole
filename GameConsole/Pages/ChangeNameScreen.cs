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
    internal class ChangeNameScreen:Screen
    {
        //public User user { get; set; }
        public ChangeNameScreen() : base("Change User Details Screen") { }
            //this.user = ConsoleGame.user;
        

        public override void Show()
        {
            base.Show();
            while (true) {
               
                Console.WriteLine("Enter the new name: ");
                string name = Console.ReadLine();
                if (name == null) {
                    Console.WriteLine("You have to enter something.");
                    continue;
                }
                try {
                    ConsoleGame.user.Name = name;
                    break;
                }
                catch
                {
                    Console.WriteLine("No such user. Try again.");
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("The name was changed correctly. Press any key to continue.");
            Console.ReadKey();
            Console.ResetColor();
            Screen next = new AfterLoginMenu();
            next.Show();
            


        }
    }
}
