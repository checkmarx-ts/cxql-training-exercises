using System;

namespace BlackjackGame {
    class Menus {
        public Table Table { get; private set; }

        public Menus() {
            Table = new Table();
        }

        public void printMainMenu() {
            Console.WriteLine("This is a Blackjack Game.");
            Console.WriteLine("------------------------");
            Console.WriteLine("[1] Place a Bet");
            Console.WriteLine("[2] Roll the Dice");
            Console.WriteLine("[3] Check table status");
            Console.WriteLine("[4] Check your actual bets");
            Console.WriteLine("[0] Exit Game");
            int option = 0;

            do {
                Console.Write(">>> ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option) {
                    case 1:
                        printBetsMenu();
                        break;
                    case 3:
                        Table.checkActualStatus();
                        break;
                    case 4:
                        Table.printBets();
                        break;
                }
            } while (option <= 0);
        }

        public void printBetsMenu() {

        }
    }
}