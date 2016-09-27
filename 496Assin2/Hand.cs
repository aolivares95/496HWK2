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
                sum += i.GetRank().val;
            }
            return sum;
        }

        public bool ContainsCard(Card aCard)
        {
            if (myHand.Contains(aCard))
            {
                return true;
            }

            return false;
        }

        public void DiscardHand()
        {
            myHand.Clear();
        }

        public int FindCard(Card nuCard)
        {
            return myHand.IndexOf(nuCard);
        }

        public Card GetCardAtIndex(int ind){
            return myHand[ind];
            }

        public int GetNumberOfCards()
        {
            return myHand.Count;
        }

        public bool IsEmpty()
        {
            if (myHand.Count == 0)
            {
                return true;
            }
            return false;
        }
        public Card RemoveCard(Card nuCard)
        {
            myHand.Remove(nuCard);
            return nuCard;
        }

        public Card RemoveCard(int cind)
        {
            myHand.RemoveAt(cind);
            return myHand[cind];
        }
    }
}
