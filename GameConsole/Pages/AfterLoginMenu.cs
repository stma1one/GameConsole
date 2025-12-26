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
        public AfterLoginMenu():base("User Menu")
        {
            Add(new MenuItem("User Details", new UserDetailsMenu()));
            Add(new MenuItem("Games List", new GameMenu()));
            Add(new MenuItem("Watch the scores", new GameHistoryScreen()));
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
