using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeGokkers
{
    public class Bet
    {
        public int Amount;   //Het bedrag van de weddenschap.         
        public int Dolphin;      //Het nummer van de dolfijn waarop weddenschap is afgesloten.         
        public Guy Bettor;   //De gokker die gewed heeft. 
        public string Description;

        public string GetDescription()
        {
            if (Amount < 5 || Amount > 15 || Amount == 0)
            {

            }
            else
            {
                Description = String.Format("{0} wedt {1} euro op vis #{2}.", Bettor.Name, Amount, Dolphin);    //Retourneer een string die aangeeft wie de weddenschap heeft gedaan, voor welk bedrag er is gewed en op welke dolfijn er is gewed.               
            }
            return Description;
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dolphin)
            {
                return 2 * Amount;              //Als de dolfijn gewonnen heeft, retourneer dan het bedrag dat gewed is      
            }
            else
            {
                return 0;                       //Anders, retourneer het tegengestelde van het gewedde bedrag.  
            }                                           
        } 
    }
}
