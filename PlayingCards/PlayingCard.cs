using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PlayingCards
{
    public class PlayingCard
    {
        public CardRank Rank { get; set; }
        public CardSuit Suit { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public string Abbrev { get; set; }
        public bool IsFaceUp { get; set; }
        public Image FrontImage { get; set; }
        public Image BackImage { get; set; }

        public PlayingCard(CardRank rank, CardSuit suit)
        {
            Points = 0;
            FrontImage = null;
            BackImage = null;
            Rank = rank;
            Suit = suit;
            ID = (int)Suit * 13 + (int)Rank;
            Name = string.Format("{0} of {1} ", rank, suit);
            Abbrev = GetDefaultAbbrev();
            IsFaceUp = false;
        }
        private string GetDefaultAbbrev()
        {
            if (Rank >= CardRank.Two && Rank <= CardRank.Nine)
            {
                int ordRank = (int)Rank + 1;
                return string.Format("{0}{1}", ordRank, Suit.ToString()[0]);
            }
            else
            {
                return string.Format("{0}{1}", Rank.ToString()[0], Suit.ToString()[0]);
            }
        }
        public void Flip()
        {
            IsFaceUp = !IsFaceUp;
        }
        public Image GetImage()
        {
            if (IsFaceUp == true)
            {
                return FrontImage;
            }
            else
            {
                return BackImage;
            }
        }
        public override String ToString()
        {
            return Name;
        }
    }
}
