using GameConsole.Base;
using GameConsole.Base;
using GameConsole.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class UserDetailsMenu:MenuScreen
    {
        public UserDetailsMenu() : base("User Details Menu")
        {
            Add(new MenuItem("Fluffy Bird", new GameScreen("Fluffy Bird", new FluffyBirdGame())));
            Add(new MenuItem("Pac Man", new GameScreen("Pac Man", new PacManGame())));
        }
    }
}
