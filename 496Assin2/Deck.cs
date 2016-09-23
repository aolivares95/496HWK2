using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496Assin2
{

    class Deck
    {
        private int deckSize;
        static List<Card> deck;
        Random rnd = new Random();
        
        public Deck(int deckSize2)
        {
            deck= new List<Card> { };
            deckSize = deckSize2;
        }

        public void AddCard(Card newCard)
        {
            if (deck.Count < deckSize)
            {
                deck.Add(newCard);
            }
            
        }

        public Card DealOne()
        {
            int rnd1 = rnd.Next(0,deck.Count);
            Card temp = deck[rnd1];
            deck.RemoveAt(rnd1);
            return temp;
        }

        public int GetCardsRemaining()
        {
            return deck.Count;
        }

        public int GetDeckSize()
        {
            return deckSize;
        }
    

    }
}
