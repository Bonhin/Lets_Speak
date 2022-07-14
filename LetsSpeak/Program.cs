using LetsSpeak.View;
using System;
using System.Collections.Generic;

namespace LetsSpeak
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataBase.Initialize();

            ConsoleView.SetPrompt();                     

            ConsoleView.MenuGenerator();

        }
    }
}
