namespace GameOfWar
{
    public class Card
    {

        // Create a string property Suit with a private setter
        public string Suit {get; private set;}
        // Create an int property Rank with a private setter - values should range from 0 for a face value of 2 to 12 for an Ace
        public int Rank {get; private set;}

        // Create a public constructor that takes suit and rank as arguments and assigns them to Suit and Rank
        public Card(string suit, int rank)
        {
            if (suit == null) throw new ArgumentNullException(nameof(suit));
            if (rank < 0 || rank > 12) throw new ArgumentOutOfRangeException(nameof(rank), "Rank must be between 0 and 12.");
            Suit = suit;
            Rank = rank;
        }
        // Overload the > operator to compare two cards by rank
        public static bool operator >(Card a, Card b) => a is null ? false : b is null ? true : a.Rank > b.Rank;

        // Overload the < operator to compare two cards by rank
        public static bool operator <(Card a, Card b) => a is null ? b is not null : b is null ? false : a.Rank < b.Rank;

        // Create a public string method RankString that returns a string representation of this card's rank, 2-10 and Jack, Queen, King, Ace
        public string RankString()
        {
            switch (Rank)
            {
                case 0: return "2";
                case 1: return "3";
                case 2: return "4";
                case 3: return "5";
                case 4: return "6";
                case 5: return "7";
                case 6: return "8";
                case 7: return "9";
                case 8: return "10";
                case 9: return "Jack";
                case 10: return "Queen";
                case 11: return "King";
                case 12: return "Ace";
                default: throw new InvalidOperationException("Invalid rank value.");
            }
        }
    }
}