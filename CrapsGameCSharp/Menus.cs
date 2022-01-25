using System;

namespace CrapsGame {
    class Menus {
        public Table Table { get; private set; }

        public static void printMainMenu() {
            Console.WriteLine("This is a Craps Game.");
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

        static void printBetsMenu() {
            Console.WriteLine("Bet Modes");
            Console.WriteLine("------------------------");
            Console.WriteLine("[1] Pass");
            Console.WriteLine("[2] Don't Pass");
            Console.WriteLine("[4] Place 4");
            Console.WriteLine("[5] Place 5");
            Console.WriteLine("[6] Place 6");
            Console.WriteLine("[8] Place 8");
            Console.WriteLine("[9] Place 9");
            Console.WriteLine("[10] Place 10");
            Console.WriteLine("[0] Back to Previous Menu");

            int option = 0;

            do {
                int amount = 0;
                Console.Write(">>> ");
                option = Convert.ToInt32(Console.ReadLine());

                if (option != 0) {
                    Console.Write("[Amount] >>> ");
                    amount = Convert.ToInt32(Console.ReadLine());
                }

                switch (option) {
                    case 1:
                        Table.placePass(amount);
                        break;
                    case 2:
                        Table.placeDontPass(amount);
                        break;
                    case 4:
                        Table.placeFour(amount);
                        break;
                    case 5:
                        Table.placeFive(amount);
                        break;
                    case 6:
                        Table.placeSix(amount);
                        break;
                    case 8:
                        Table.placeEight(amount);
                        break;
                    case 9:
                        Table.placeNine(amount);
                        break;
                    case 10:
                        Table.placeTen(amount);
                        break;
                }
            } while (option <= 0);
        }
    }
}