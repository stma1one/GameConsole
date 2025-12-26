using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Models;

namespace GameConsole.Pages
{
    internal class GameHistoryScreen:MenuScreen
    {
        public List<HighScore> Scores { get; set; }
        public GameHistoryScreen():base("Game History Screen")
        {
            Add(new MenuItem("Show last game's score", new ShowLastGaneScreen()));
            Add(new MenuItem("Sort by result", new SortHistoryByScoreScreen()));
            Add(new MenuItem("Sort by game name", new SortHistoryGameByNameScreen()));
        }
        public override void Show()
        {
            base.Show();
        }

    }
}
