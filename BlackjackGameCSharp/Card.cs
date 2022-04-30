namespace BlackjackGame
{
    class Card
    {
        public CardRank Rank { get; set; }
        public CardSuit Suit { get; set; }

        public int GetCardValue()
        {
            switch (Rank)
            {
                case CardRank.Ace:
                    return 1;
                case CardRank.Two:
                    return 2;
                case CardRank.Three:
                    return 3;
                case CardRank.Four:
                    return 4;
                case CardRank.Five:
                    return 5;
                case CardRank.Six:
                    return 6;
                case CardRank.Seven:
                    return 7;
                case CardRank.Eight:
                    return 8;
                case CardRank.Nine:
                    return 9;
                default:
                    return 10;
            }
        }

        public override string ToString()
        {
            return Rank + " of " + Suit;
        }
    }
}