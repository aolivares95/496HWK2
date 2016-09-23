using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496Assin2
{
    class Deck
    {
        static List<Card> deck;
        Random rnd = new Random();
        
        public Deck()
        {
            deck= new List<Card> { };
        }

        public void AddCard(Card newCard)
        {
            deck.Add(newCard);
        }

        public Card DealOne()
        {
            int rnd1 = rnd.Next(0,deck.Count);
            Card temp = deck[rnd1];
            deck.RemoveAt(rnd1);
            return temp;
        }
    }
}
