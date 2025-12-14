using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsole.Base;
using GameConsole.Data;
namespace GameConsole.Pages
{
    internal class ChangePasswordScreen:Screen
    {

        public ChangePasswordScreen() : base("Change Password Screen") { }

        public override void Show()
        {
            while (true)
            {

                Console.WriteLine("Enter the new password: ");
                string pass = Console.ReadLine();
                if (pass == null || pass == "")
                {
                    Console.WriteLine("You have to enter somthing.");
                    continue;
                }
                try
                {
                    UserDB.Update = pass;
                    break;
                }
                catch
                {
                    Console.WriteLine("Error: No such user.");
                }
            }

        }

    }
}
