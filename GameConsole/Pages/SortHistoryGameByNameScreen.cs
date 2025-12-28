using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GameConsole;


namespace GameConsole.Pages
{
    internal class SortHistoryGameByNameScreen:Screen
    {
        public List<HighScore> Scores {  get; set; }
        public SortHistoryGameByNameScreen():base("Sort History Game By Name Screen"){}

        public override void Show()
        {
            base.Show();
            var names = ConsoleGame.user.AllScores.OrderByDescending(name => name.Name);
            if (names != null)
            {
                int i = 1;
                foreach (var name in names)
                {
                    //.Pastel(Color.FromArgb(255, 215, 0)
                    // string write = i.ToString() + ". Score: " + score.Score + ", game: " + score.Name;
                    Console.WriteLine(i.ToString() + ". Game: " + name.Name +  ", score: " + name.Score + ", date: " + name.Date);
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
