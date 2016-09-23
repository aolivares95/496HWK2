using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496Assin2
{
    class Card
    {
       private Suit mySuit;
       private Rank myRank;

        public Card(Suit newSuit, Rank newRank)
        {
            mySuit = newSuit;
           myRank = newRank;
        }


        public int CompareTo(Card newCard)
        {
            return this.myRank.CompareTo(newCard.myRank);
        }
        
        public Rank GetRank()
        {
            return myRank;
        }

        public Suit GetSuit()
        {

            return mySuit;
        }

        public override string ToString()
        {
            return "Rank is: " + myRank + " Suit is: " + mySuit;

        }

    }
}
