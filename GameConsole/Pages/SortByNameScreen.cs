using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class SortByNameScreen : Screen
    {
        public SortByNameScreen() : base("SortByNameScreen") { }
        public override void Show()
        {
            base.Show();
            var GameName = ConsoleGame.user.AllScores.OrderBy(GameName => GameName.Name);
            foreach (var Name in GameName)
            {
                Console.WriteLine(GameName);
            }
        }
    }
}
