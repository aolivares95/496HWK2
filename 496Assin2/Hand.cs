using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496Assin2
{
    class Hand
    {
        List<Card> myHand;
        public int sum=0;

        public void AddCard(Card newCard)
        {
            myHand.Add(newCard);
        }

        public int CompareTo(Hand otherHand)
        {
            if(this.EvaluateHand()> otherHand.EvaluateHand())
            {
                return 1;
            }

            if (this.EvaluateHand() < otherHand.EvaluateHand())
            {
                return -1;
            }

            return 0;

        }

        public int EvaluateHand()
        {
            foreach(Card i in myHand)
            {
                sum = i.GetRank().val;
            }
            return sum;
        }
    }
}
