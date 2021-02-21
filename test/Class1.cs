using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards;

namespace test
{
    class Program
    {
   static void Main(string[] args)
        {
            Deck mtg = new Deck();
            PlayingCard topCard = mtg.DealTopCard();
            while ( topCard != null)
            {
                Console.WriteLine(topCard);
                topCard = mtg.DealTopCard();
            }
            Console.ReadLine();
        }
    }
}