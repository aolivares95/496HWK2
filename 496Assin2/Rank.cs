using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496Assin2
{
    class Rank
    {
        private string symbol;
        private int val;
        private string name;

        static List<Rank> values= new List<Rank> { };

        public Rank(string ns, int nv, string nn)
        {
            symbol = ns;
            val = nv;
            name = nn;
        }

        static Rank()
        {

            Rank ONE = new Rank("1", 1, "One");
            Rank TWO = new Rank("2", 2, "Two");
            Rank THREE = new Rank("3", 3, "Three");
            Rank FOUR = new Rank("4", 4, "Four");
            Rank FIVE = new Rank("5", 5, "Five");
            Rank SIX = new Rank("6", 6, "Six");
            Rank SEVEN = new Rank("7", 7, "Seven");
            Rank EIGHT = new Rank("8", 8, "Eight");
            Rank NINE = new Rank("9", 9, "Nine");
            Rank TEN = new Rank("10", 10, "Ten");
            Rank JACK = new Rank("J", 11, "Eleven");
            Rank QUEEN = new Rank("Q", 12, "Queen");
            Rank KING = new Rank("K",13,"King");
            Rank ACE = new Rank("A", 14, "Ace");
        }

        

        int CompareTo(Rank rankObj)
        {
            if (this.val < rankObj.val)
            {
                return -1;
            }

            if (this.val > rankObj.val)
            {
                return 1;
            }
            return 0;
        }
     
    }
}
