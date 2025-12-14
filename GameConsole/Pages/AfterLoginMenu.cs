using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;


namespace GameConsole.Pages
{
    internal class AfterLoginMenu:MenuScreen
    {
        public AfterLoginMenu():base("After Login Menu")
        {
            Add(new MenuItem("User Details", new UserDetailsMenu()));
            Add(new MenuItem("Games List", new GameMenu()));
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
