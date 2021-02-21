using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class Deck
    {
        List<PlayingCard> cards = new List<PlayingCard>();
        public Deck()
        {
            for (CardSuit suit = CardSuit.Clubs; suit <= CardSuit.Spades; suit++)
            {
                for (CardRank rank = CardRank.Ace; rank <= CardRank.King; rank++)
                {
                    cards.Add(new PlayingCard(rank, suit));
                }
            }

        }
        public bool IsEmpty()
        {
            if (!cards.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public PlayingCard DealTopCard()
        {
            if (this.IsEmpty() == true)
            {
                return null;
            }
            else
            {
                PlayingCard topCard = cards[0];
                cards.RemoveAt(0);
                return topCard;
            }
        }
    }
}
