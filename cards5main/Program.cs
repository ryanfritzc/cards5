using System;
using System.Collections.Generic;
using System.Linq;


namespace cards5main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play some 5 card draw!" +
                              "\nThe rules are simple: Who ever has the best hand wins, you can exchange up to 3 cards in order to better your hand." +
                              "\nYou can raise or fold on the intial hand and after the card exchange, here are your inital 50 coins, Good Luck!");
        }

        
        public static void TesterM(int []card)
        {
            int tester = 0;
            string testerS = "";
            for (int i = 0; i < 52; i++)
            {

                testerS += card[i] + " ";
                tester++;
                if (tester == 26)
                {
                    Console.WriteLine(testerS);
                    tester = 0;
                    testerS = "";
                }
            }
            Console.WriteLine("\n");
        }
    }
    public class Card
    {
        public enum Suits
        {
            Spades,
            Hearts,
            Clubs,
            Diamonds
        }
        public enum Values
        {
            Two = 2,
            Three = 3,
            Four = 4, 
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12, 
            King = 13,
            Ace = 14,
        }
        public Suits getSuits { get; set; }
        public Values getValues { get; set; }
    }
    public class Deck
    {
        public const int CARDNUM = 52;
        private Card[] deck;

        public Deck()
        {
            deck = new Card[CARDNUM];
        }
        public Card[] getDeck { get; { return deck; } }

        public void createDeck()
        {
            int index = 0;
            foreach(Card.Suits s in Enum.GetValues(typeof(Card.Suits)))
            {
                foreach(Card.Values v in Enum.GetValues(typeof(Card.Values)))
                {
                    deck[index] = new Card { getSuits = s, getValues = v };
                    index++;
                }
            }
            Shuffle();
        }
        public void Shuffle()
        {
            Random rng = new Random();
            Card temp;
            for (int shuffle = 0; shuffle < 10; shuffle++)
            {
                for ( int i = 0; i < CARDNUM; i++)
                {
                    int swapCard = rng.Next(13);
                    temp = deck[i];
                    deck[i] = deck[swapCard];
                    deck[swapCard] = temp;

                }
            }
        }
    }
}
