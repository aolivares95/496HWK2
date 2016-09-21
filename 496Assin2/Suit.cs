using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496Assin2
{
    class Suit
    {
        private string symbol;
        private string name;
        private int val;

        public Suit(string symbol2, string name2, int val2)
        {
            symbol = symbol2;
            name = name2;
            val = val2;
        }

        static Suit(){
            Suit CLUBS = new Suit("C","Club",1);
            Suit DIAMONDS = new Suit("D","Diamond",2);
            Suit HEARTS = new Suit("H", "Hearts", 3);
            Suit SPADES = new Suit("S", "Spades", 4);
        }
    }
}
