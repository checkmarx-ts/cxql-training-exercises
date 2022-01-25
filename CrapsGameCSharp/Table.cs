using System;

namespace CrapsGame {
    class Table {
        public int Pass { get; private set; }
        public int DontPass { get; private set; }
        public int Three { get; private set; }
        public int Four { get; private set; }
        public int Five { get; private set; }
        public int Six { get; private set; }
        public int Eight { get; private set; }
        public int Nine { get; private set; }
        public int Ten { get; private set; }

        public int? Point { get; private set; }

        public void restartGame() {
            Pass = 0;
            DontPass = 0;
            Four = 0;
            Five = 0;
            Six = 0;
            Eight = 0;
            Nine = 0;
            Ten = 0;
        }

        public void placePass(int amount) {
            Pass += amount;
        }

        public void placeDontPass(int amount) {
            DontPass += amount;
        }

        public void placeFour(int amount) {
            Four += amount;
        }

        public void placeFive(int amount) {
            Five += amount;
        }

        public void placeSix(int amount) {
            Six += amount;
        }

        public void placeEight(int amount) {
            Eight += amount;
        }

        public void placeNine(int amount) {
            Nine += amount;
        }

        public void placeTen(int amount) {
            Ten += amount;
        }

        public void printBets() {
            Console.WriteLine("Actual Bets.");
            Console.WriteLine("------------------------");
        }

        public void checkActualStatus() {
            Console.WriteLine("Table actual status.");
            Console.WriteLine("------------------------");
        }
    }
}