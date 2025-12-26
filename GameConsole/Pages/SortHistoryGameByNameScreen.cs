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
        public SortHistoryGameByNameScreen():base("Sort History Game By Name Screen"){}

        public override void Show()
        {
            base.Show();
            var scores = ConsoleGame.user.AllScores.OrderBy(score => score.Name);
            if (scores != null)
            {
                foreach (var score in scores)
                {
                    Console.WriteLine(score);
                }
            }
            else
            {
                Console.WriteLine("You didn't played any game yet.");
            }
        }
    }
}
