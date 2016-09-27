using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496Assin2
{
    public class Card
    {
       
       public Suit mySuit;
       public Rank myRank;
       Random rnd = new Random();

        public Card(Suit newSuit, Rank newRank)
        {
            mySuit = newSuit;
           myRank = newRank;
        }

        public Card()
        {
            myRank = Rank.values[rnd.Next(0,13)];
            mySuit = Suit.values[rnd.Next(0, 3)];
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
