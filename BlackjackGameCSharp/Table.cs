using System;
using System.Collections.Generic;

namespace BlackjackGame
{
    class Table
    {
        public int CurrentBet { get; private set; }
        
        public List<Card> PlayerCards { get; private set; }
        public List<Card> DealerCards { get; private set; }
        public Deck CardDeck { get; private set; }

        public Table()
        {
            
            PlayerCards = new List<Card>();
            DealerCards = new List<Card>();
            CardDeck = new Deck();
        }

        public void GetPlayerBet(Player player)
        {
            Console.Write("[Your bet] >>> ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CurrentBet = 10;
                    player.ActualBalance -= 10;
                    break;
                case 3:
                    CurrentBet = 20;
                    player.ActualBalance -= 20;
                    break;
                case 4:
                    GetCustomBetAmount(player);
                    break;
            }

            player.RoundsPlayed++;
        }

        private void GetCustomBetAmount(Player player)
        {
            int amount;
            do
            {
                Console.Write("[Enter custom amount] >>> ");
                amount = Convert.ToInt32(Console.ReadLine());
                CurrentBet = amount;
                player.ActualBalance -= amount;
            } while (amount <= 0);
        }

        internal void StartGame(Player player)
        { 
            PlayerCards.Add(CardDeck.DrawCard());
            DealerCards.Add(CardDeck.DrawCard());
            PlayerCards.Add(CardDeck.DrawCard());
            DealerCards.Add(CardDeck.DrawCard());

            int playerHand = GetPlayerHand();
            int dealerHand = GetDealerHand();

            if (playerHand == 21)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Player got a Blackjack");
                player.ActualBalance += CurrentBet * 2;
                return;
            }

            if (dealerHand == 21)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("House got a Blackjack");
                return;
            }

            GetPlayerChoice();
        }

        internal int GetPlayerChoice()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Please choose hit, stand or double.");
            Console.WriteLine("------------------------");
            Console.WriteLine("[1] Hit");
            Console.WriteLine("[2] Stand");
            Console.WriteLine("[3] Double");
            Console.WriteLine("------------------------");

            return Convert.ToInt32(Console.Read());
        }

        internal int GetPlayerHand()
        {
            int playerHand = 0;
            Console.WriteLine("Your hand:");
            Console.WriteLine("------------------------");
            foreach (var playerCard in PlayerCards)
            {
                Console.WriteLine("- " + playerCard + "(" + playerCard.GetCardValue() + ")");
                playerHand += playerCard.GetCardValue();
            }

            return playerHand;
        }

        internal int GetDealerHand()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Dealer has:");
            Console.WriteLine("------------------------");
            Console.WriteLine("- " + DealerCards[0] + "(" + DealerCards[0].GetCardValue() + ")");
            Console.WriteLine("------------------------");

            return DealerCards[0].GetCardValue();
        }

        internal void CheckTableStatus()
        {
            Console.WriteLine("Table Status");
        }
    }
}