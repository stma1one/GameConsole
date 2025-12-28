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
            Add(new MenuItem("Show last game's name", new ShowLastGaneScreen()));
            Add(new MenuItem("Sort by name", new SortHistoryByScoreScreen()));
           
        }
        public override void Show()
        {
            base.Show();
        }

    }
}
