using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class SortHistoryByScoreScreen:Screen
    {
        public SortHistoryByScoreScreen():base("History Score"){}

        public override void Show()
        {
            base.Show();
            var scores = ConsoleGame.user.AllScores.OrderBy(score => score.Score);
            if (scores != null)
            {
                foreach (var score in scores)
                {
                    Console.WriteLine(score);
                }
            }
            else
            {
                Console.WriteLine("You stil didn't played any game.");
            }
        }
    }
}
