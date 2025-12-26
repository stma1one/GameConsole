using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public HighScore HighScore { get; set; }
        public List<HighScore> AllScores { get; set; }
        public User(string name, string userName, string password)
        {
            this.Name = name;
            this.Password = password;
            this.UserName = userName;
            this.HighScore = null;
            this.AllScores = new List<HighScore>();
        }
       
    }
}
