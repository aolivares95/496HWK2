using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496Assin2
{
    public class CardCountHand : Hand
    {
        
        public override int CompareTo(Hand otherHand)
        {
            if (this.EvaluateHand() > otherHand.EvaluateHand())
            {
                return 1;
            }

            if (this.EvaluateHand() < otherHand.EvaluateHand())
            {
                return -1;
            }

            return 0;

        }

        public override int EvaluateHand()
        {
            int count = 0;
            foreach (Card i in deck1.deck)
            {
                sum += deck1.deck[count].GetRank().val;
            }

            return sum;
        }


    }
    
}
