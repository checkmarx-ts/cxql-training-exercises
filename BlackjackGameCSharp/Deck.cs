using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackGame {
    class Deck {
        private static readonly Random rng = new Random();
        public Dictionary<CardSuit, string> CardSuitsDictionary { get; private set; }
        public Stack<Card> Cards { get; private set; }

        public Deck() {
            CardSuitsDictionary = new Dictionary<CardSuit, string>
            {
                // "♠, ♣, ♥, ♦"
                { CardSuit.Spades, "♠" },
                { CardSuit.Clubs, "♣" },
                { CardSuit.Hearts, "♥" },
                { CardSuit.Diamonds, "♦" }
            };

            Cards = new Stack<Card>(new List<Card> {
                new Card { Rank = CardRank.Ace, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Two, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Three, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Four, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Five, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Six, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Seven, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Eight, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Nine, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Ten, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Jack, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.Queen, Suit = CardSuit.Spades },
                new Card { Rank = CardRank.King, Suit = CardSuit.Spades },

                new Card { Rank = CardRank.Ace, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Two, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Three, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Four, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Five, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Six, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Seven, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Eight, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Nine, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Ten, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Jack, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.Queen, Suit = CardSuit.Clubs },
                new Card { Rank = CardRank.King, Suit = CardSuit.Clubs },

                new Card { Rank = CardRank.Ace, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Two, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Three, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Four, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Five, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Six, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Seven, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Eight, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Nine, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Ten, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Jack, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.Queen, Suit = CardSuit.Hearts },
                new Card { Rank = CardRank.King, Suit = CardSuit.Hearts },

                new Card { Rank = CardRank.Ace, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Two, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Three, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Four, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Five, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Six, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Seven, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Eight, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Nine, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Ten, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Jack, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.Queen, Suit = CardSuit.Diamonds },
                new Card { Rank = CardRank.King, Suit = CardSuit.Diamonds }
            }.OrderBy(a => rng.Next()));
        }

        public Card DrawCard()
        {
            return Cards.Pop();
        }
    }
}