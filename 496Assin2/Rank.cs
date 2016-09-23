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
        

        public static Rank TWO = new Rank();
        public static Rank THREE = new Rank();
        public static Rank FOUR = new Rank();
        public static Rank FIVE = new Rank();
        public static Rank SIX = new Rank();
        public static Rank SEVEN = new Rank();
        public static Rank EIGHT = new Rank();
        public static Rank NINE = new Rank();
        public static Rank TEN = new Rank();
        public static Rank JACK = new Rank();
        public static Rank QUEEN = new Rank();
        public static Rank KING = new Rank();
        public static Rank ACE = new Rank();

        public static List<Rank> values = new List<Rank> { };

        public Rank()
        {


        }

        public Rank(string ns, int nv, string nn)
        {
            symbol = ns;
            val = nv;
            name = nn;
        }
        
        static Rank()
        {

            TWO = new Rank("2", 2, "Two");
            THREE = new Rank("3", 3, "Three");
            FOUR = new Rank("4", 4, "Four");
            FIVE = new Rank("5", 5, "Five");
            SIX = new Rank("6", 6, "Six");
            SEVEN = new Rank("7", 7, "Seven");
            EIGHT = new Rank("8", 8, "Eight");
            NINE = new Rank("9", 9, "Nine");
            TEN = new Rank("10", 10, "Ten");
            JACK = new Rank("J", 11, "Eleven");
            QUEEN = new Rank("Q", 12, "Queen");
            KING = new Rank("K",13,"King");
            ACE = new Rank("A", 14, "Ace");

            values.Add(TWO);
            values.Add(THREE);
            values.Add(FOUR);
            values.Add(FIVE);
            values.Add(SIX);
            values.Add(SEVEN);
            values.Add(EIGHT);
            values.Add(NINE);
            values.Add(TEN);
            values.Add(JACK);
            values.Add(QUEEN);
            values.Add(KING);
            values.Add(ACE);
        }
       
        public int CompareTo(Rank rankObj)
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

        public string GetSymbol()
        {
            return this.symbol;
        }

        public string GetName()
        {

            return this.name;
        }
     
        public string ToString()
        {
            return this.name;
        }
    }
}
