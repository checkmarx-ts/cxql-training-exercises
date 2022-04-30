using System;

namespace BlackjackGame
{
    class Player
    {
        public int ActualBalance { get; set; }
        public int RoundsPlayed { get; set; }

        public Player()
        {
            ActualBalance = 1000;
            RoundsPlayed = 0;
        }

        public void PrintPlayerBalance()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Actual balance: {ActualBalance}");
            Console.WriteLine("Rounds played: {RoundsPlayed}");
        }
    }
}
