using System;

namespace cards5main
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] cards = {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,
                           26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51};
            
            Console.WriteLine("original");
            TesterM(cards);

            Console.WriteLine("shuffled");
            Shuffle(cards, 52);
            TesterM(cards);
            

            Console.WriteLine("Lets play some 5 card draw!" +
                              "\nThe rules are simple: Who ever has the best hand wins, you can exchange up to 3 cards in order to better your hand." +
                              "\nYou can raise or fold on the intial hand and after the card exchange, here are your inital 50 coins, Good Luck!");
        }
        public static void Shuffle(int[] card, int n)
        {
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
                int s = i + rng.Next(52 - i);
                int temp = card[s];
                card[s] = card[i];
                card[i] = temp;
            }
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
}
