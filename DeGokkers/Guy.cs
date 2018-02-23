using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeGokkers
{
    public class Guy
    {
        public string Name;  // De naam van de gokker         
        public Bet MyBet;    // Een instantie van Bet()         
        public int Cash;     // Het saldo van de gokker 

        //Deze twee velden zijn de gokkers GUI controls op het formulier         
        public RadioButton MyRadiobutton;
        public TextBox MyLabel;

        public Guy()
        {

        }
        public void UpdateLabels()
        {
            if(MyBet == null)
            {
                MyLabel.Text = Name + " heeft geen weddenschap geplaatst.";
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();                   //Verander mijn label in de omschrijving van mijn weddenschap.  
            }
            MyRadiobutton.Text = Name + " heeft " + Cash + " euro.";        //Verander de label op mijn radioknop zodat deze mijn saldo laat zien.          
        } 

        public bool PlaceBet(int amount, int dog)
        {
            if (Cash < amount)
            {
                MessageBox.Show("Je hebt niet genoeg geld!", "FOUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (amount < 5 || amount > 15)
                {
                    MessageBox.Show("Je moet minimaal 5 euro wedden en kan maximaal 15 euro wedden!", "FOUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    this.MyBet = new Bet()                                      //Plaats een nieuwe weddenschap en sla het op in de variabele MyBet. 
                    {
                        Amount = amount,
                        Bettor = this,
                        Dolphin = dog
                    };
                    this.Cash -= amount;
                    this.MyRadiobutton.Enabled = false;
                    this.MyRadiobutton.Checked = false;
                    return true;                                                //Retourneer een true als de gokker genoeg geld heeft om te wedden.       
                }
            }       
        }

        public void ClearBet()
        {
            this.MyBet = null;             
        } 

        public void Collect(int Winner)
        {
            if (MyBet == null)
            {
                this.MyRadiobutton.Enabled = true;
                this.UpdateLabels();
            }
            else
            {
                Cash += this.MyBet.PayOut(Winner);      //Betaal mijn weddenschap uit. 
                this.ClearBet();                        //Maak mijn weddenschap leeg.
                this.MyRadiobutton.Enabled = true;
                this.UpdateLabels();                    //Werk mijn labels bij.
            }
        } 
    }
}
