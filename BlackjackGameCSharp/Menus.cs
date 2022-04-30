using System;

namespace BlackjackGame {
    class Menus {
        public Table Table { get; private set; }
        public Player Player { get; private set; }

        public Menus() {
            Table = new Table();
            Player = new Player();
        }

        public void PrintMainMenu() {
            int option;
            do
            {
                Console.WriteLine("This is a Blackjack Game.");
                Console.WriteLine("------------------------");
                Console.WriteLine("[1] Place a Bet");
                Console.WriteLine("[2] Start round");
                Console.WriteLine("[3] Check table status");
                Console.WriteLine("[4] Check your balance");
                Console.WriteLine("[0] Exit Game");

                Console.WriteLine("------------------------");
                Console.Write("[Your choice] >>> ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option) {
                    case 1:
                        int betChoice = PrintBetsMenu();
                        if (betChoice == 3) {
                            Table.GetPlayerBet(Player);
                        }
                        break;
                    case 2:
                        PrintBetsMenu();
                        Table.GetPlayerBet(Player);
                        Table.StartGame(Player);
                        break;
                    case 3:
                        Table.CheckTableStatus();
                        break;
                    case 4:
                        Player.PrintPlayerBalance();
                        break;
                }
            } while (option > 0);
        }

        public int PrintBetsMenu() {
            Console.WriteLine("Bets available.");
            Console.WriteLine("------------------------");
            Console.WriteLine("[1] Minimum: $10");
            Console.WriteLine("[2] Double: $20");
            Console.WriteLine("[3] Custom bet value");
            Console.WriteLine("[0] Exit Game");
            Console.WriteLine("------------------------");
            Console.Write("[Your choice] >>> ");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}