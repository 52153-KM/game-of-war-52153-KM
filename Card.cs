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

        // Note: The lines of code used to overload an operator, are not explained in any of the course material.
        // I freely and fully admit to having used AI assistance to write these two operator overloads.
        // I understand if points are subtracted for this.
        // I just wish to express my frustration that one of the assignment requriements 
        // is something i have never learned, or been instructed to use previously

        // Overload the > operator to compare two cards by rank
        public static bool operator >(Card a, Card b) => a is null ? false : b is null ? true : a.Rank > b.Rank;

        // Overload the < operator to compare two cards by rank
        public static bool operator <(Card a, Card b) => a is null ? b is not null : b is null ? false : a.Rank < b.Rank;

        // Create a public string method RankString that returns a string representation of this card's rank, 2-10 and Jack, Queen, King, Ace
        public string RankString()
        {
            // Note: Lambda operators were also not covered in the course material.
            // These I learned about from external research.
            return Rank switch
            {
                0 => "2",
                1 => "3",
                2 => "4",
                3 => "5",
                4 => "6",
                5 => "7",
                6 => "8",
                7 => "9",
                8 => "10",
                9 => "Jack",
                10 => "Queen",
                11 => "King",
                12 => "Ace",
                _ => throw new InvalidOperationException("Invalid rank value.")
            };
        }

    }
}