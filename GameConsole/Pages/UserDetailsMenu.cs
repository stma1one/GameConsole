using GameConsole.Base;
using GameConsole.Base;
using GameConsole.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class UserDetailsMenu:MenuScreen
    {
        public UserDetailsMenu() : base("User Details Menu")
        {
            Add(new MenuItem("Watch User Details", new WatchUserDetailsScreen()));
            Add(new MenuItem("Change Name", new ChangeNameScreen()));
            Add(new MenuItem("Change Password", new ChangePasswordScreen()));
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
