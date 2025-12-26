using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Base
{
    public class Screen
    {
        public string Title { get; set; }
        public Screen(string title)
        {
            Title = title;
        }
        public virtual void Show()
        {
            Console.Clear();
            // Console.BackgroundColor = ConsoleColor.DarkCyan;
            CenterText(Title);
            
        }

        public void CenterText(string text)
        {
            Console.SetCursorPosition(Console.WindowTop + Console.WindowWidth / 2 - text.Length / 2, Console.CursorTop);
            // Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public void CenterTextWithoutNewLine(string text)
        {
            // תנאי כניסה: מקבלת מחרוזת
            // תנאי יציאה: מדפיסה למסך את המחרוזת ממורכזת בלי לרדת שורה בסוף ההדפסה
            Console.SetCursorPosition(Console.WindowTop + Console.WindowWidth / 2 - text.Length / 2, Console.CursorTop);
            // Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(text);
            Console.ResetColor();
        }

        public virtual void BackColor() { }
    }
}
