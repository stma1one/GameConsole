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

﻿using GameConsole.Base;
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
                    Console.WriteLine(i.ToString() +  ", game: " + score.Name + ", date: " + score.Date);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("You didn't played any game yet.");
            }

            Console.WriteLine("\n\nPress any key to continue.");
            Console.ReadKey();

            Screen next = new AfterLoginMenu();
            next.Show();
        }
    }
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
