using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Models;

namespace GameConsole.Pages
{
    internal class GameHistoryScreen:Screen
    {
        public List<HighScore> Scores { get; set; }
        public GameHistoryScreen():base("Game History Screen")
        {
            Scores = ConsoleGame.user.AllScores;
        }

    }
}
