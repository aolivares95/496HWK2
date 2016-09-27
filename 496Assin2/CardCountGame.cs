using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496Assin2
{
    public class CardCountGame 
    {
        CardCountHand player1 = new CardCountHand();
        CardCountHand player2 = new CardCountHand();

        public void PlayGame()
        {
            Card rndCard = new Card();
            Card rndCard2 = new Card();
           // for (int i = 0; i < 8; i++)
            //{

                
                player1.AddCard(rndCard);
                player2.AddCard(rndCard2);
                Console.WriteLine(rndCard.ToString()+" "+rndCard2.ToString());
            //}

        }


    }
}
