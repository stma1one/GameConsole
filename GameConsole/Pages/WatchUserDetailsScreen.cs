using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Models;

namespace GameConsole.Pages
{
    internal class WatchUserDetailsScreen:Screen
    {
        public User user;
        public WatchUserDetailsScreen():base("Watch User Details Screen")
        {
            this.user = ConsoleGame.user;
        }
        public override void Show()
        {
            base.Show();
            Console.BackgroundColor = ConsoleColor.Blue;
            CenterTextWithoutNewLine("Name:");
            Console.ResetColor();
            Console.WriteLine(" " + this.user.Name);
            Console.BackgroundColor = ConsoleColor.Blue;
            CenterTextWithoutNewLine("User name:");
            Console.ResetColor();
            Console.WriteLine(" " + this.user.UserName);
            //Console.ResetColor();
        }
    }
}
