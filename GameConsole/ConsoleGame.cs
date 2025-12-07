using GameConsole.Base;
using GameConsole.Models;
using GameConsole.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class ConsoleGame
    {
        public Screen mainPage;
        public static User user;
        public ConsoleGame() {
            mainPage = new WelcomeScreen();

        }
        public void StartApp()
        {
            mainPage.Show();
        }
    }
}
