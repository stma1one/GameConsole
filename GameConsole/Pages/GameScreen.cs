using GameConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Models;



namespace GameConsole.Pages
{ 
    internal class GameScreen: Screen
    {
        public string Title { get; set; }
        public IGamePlay game;
        public double Score { get; set; }
        public GameScreen(string title, IGamePlay game) : base(title){
            this.game = game;
            this.Score = 0;
        } 
        public override void Show()
        {
            game.Play();

            HighScore newScore = new HighScore(game.Name, game.Score);
            if (ConsoleGame.user.HighScore == null || newScore.Score > ConsoleGame.user.HighScore.Score) {
                ConsoleGame.user.HighScore = newScore;
            }
            ConsoleGame.user.AllScores.Add(newScore);

        }
    }
}
