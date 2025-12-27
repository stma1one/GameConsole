using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            var scores = ConsoleGame.user.AllScores.OrderByDescending(score => score.Score);
            if (scores != null)
            {
                int i = 1;
                foreach (var score in scores)
                {
                    //.Pastel(Color.FromArgb(255, 215, 0)
                    // string write = i.ToString() + ". Score: " + score.Score + ", game: " + score.Name;
                    var color = ConsoleColor.White;
                    if (i == 1)
                        color = ConsoleColor.Yellow;
                    else if (i == 2)
                        color = ConsoleColor.DarkGray;
                    else if (i == 3)
                        color = ConsoleColor.DarkRed;
                    Console.ForegroundColor = color;
                    Console.WriteLine(i.ToString() + ". Score: " + score.Score + ", game: " + score.Name);
                    Console.ResetColor();
                    i++;
                }
            }
            else
            {
                Console.WriteLine("You didn't played any game yet.");
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nPress any key to continue.");
            Console.ResetColor();
            Console.ReadKey();

            Screen next = new AfterLoginMenu();
            next.Show();
        }
    }
}
