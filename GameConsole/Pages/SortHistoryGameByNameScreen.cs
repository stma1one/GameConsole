using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Models;


namespace GameConsole.Pages
{
    internal class SortHistoryGameByNameScreen:Screen
    {
        public List<HighScore> Scores {  get; set; }
        public SortHistoryGameByNameScreen():base("Sort History Game By Name Screen"){
            this.Scores = ConsoleGame.user.AllScores;
        }

        public override void Show()
        {
            base.Show();

        }
    }
}
