using System;

namespace BlackjackGame {
    class Blackjack {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            new Menus().PrintMainMenu();
        }
    }
}