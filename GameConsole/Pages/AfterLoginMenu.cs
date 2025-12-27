using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameConsole.Pages
{
    internal class AfterLoginMenu:MenuScreen
    {
        public AfterLoginMenu():base("User Menu")
        {
            // מוסיפים נתונים לרשימת התוצאות כדי לדמות מסד נתונים אמיתי ולאפשר צפייה בהיסטוריית המשחקים
            ConsoleGame.user.AllScores.Add(new HighScore("FluffyBird", 90));
            ConsoleGame.user.AllScores.Add(new HighScore("FluffyBird", 30));
            ConsoleGame.user.AllScores.Add(new HighScore("PacMan", 60));
            ConsoleGame.user.AllScores.Add(new HighScore("FluffyBird", 40));
            ConsoleGame.user.AllScores.Add(new HighScore("PacMan", 20));
            ConsoleGame.user.AllScores.Add(new HighScore("Tetris", 50));
            ConsoleGame.user.AllScores.Add(new HighScore("Tetris", 100));



            Add(new MenuItem("User Details", new UserDetailsMenu()));
            Add(new MenuItem("Games List", new GameMenu()));
            Add(new MenuItem("Watch the scores", new GameHistoryScreen()));
        }
        public override void Show()
        {
            base.Show();
        }
    }
}
