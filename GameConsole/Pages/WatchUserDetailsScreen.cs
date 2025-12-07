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
        public WatchUserDetailsScreen(User user):base("Watch User Details Screen")
        {
            this.user = ConsoleGame.user;
        }
        public override void Show()
        {
            base.Show();
            CenterText("Name: " + user.Name);
            CenterText("User name: " + user.UserName);
        }
    }
}
