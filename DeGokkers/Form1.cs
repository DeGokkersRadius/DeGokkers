using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DeGokkers
{
    public partial class frmMain : Form
    {
        Guy[] Bettors;
        Animal[] Animals;
        Guy currBettor;
        public bool bet;
        protected int animalnum;


        public frmMain()
        {
            InitializeComponent();
            Random randomizer = new Random();
            Bettors = new Guy[3];
            Animals = new Animal[4];

            Bettors[0] = new Guy() {
                Cash = 50,
                Name = "Sietse",
                MyRadiobutton = rbPlayer1,
                MyLabel = txtDescp1
        };

            Bettors[1] = new Guy() {
                Cash = 75,
                Name = "Lidy",
                MyRadiobutton = rbPlayer2,
                MyLabel = txtDescp2
            };

            Bettors[2] = new Guy() {
                Cash = 45,
                Name = "Fer",
                MyRadiobutton = rbPlayer3,
                MyLabel = txtDescp3
        };

            for(int i = 0; i < Animals.Length; i++)
            {
                Animals[i] = new Animal();               
                Animals[i].RaceTrackLength = pbBackground.Width - 150;
            }

            Animals[0].MyPictureBox = pbAnimal1;
            Animals[1].MyPictureBox = pbAnimal2;
            Animals[2].MyPictureBox = pbAnimal3;
            Animals[3].MyPictureBox = pbAnimal4;

            for (int i = 0; i < Bettors.Length; i++)
            {
                Bettors[i].UpdateLabels();
            }

            currBettor = Bettors[0];
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 5; i++)
            {
                var labels = (Label)Controls["lblNumber" + i];
                var picturebox = (PictureBox)Controls["pbAnimal" + i];
                picturebox.Parent = pbBackground;
                labels.Parent = pbBackground;
            }
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (rbPlayer1.Checked || rbPlayer2.Checked || rbPlayer3.Checked)
            {
                bet = currBettor.PlaceBet((int)betAmount.Value, (int)betAnimal.Value);
                currBettor.UpdateLabels();
            }
            else
            {
                MessageBox.Show("OEPS! Er is iets fout gegaan, probeer het later nog eens!", "FOUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
            for(int i = 0; i < Bettors.Length; i++)
            {
                Bettors[i].UpdateLabels();
            }
        }

        private void SetBettor(int bettor)
        {
            currBettor = Bettors[bettor];

            if (currBettor.MyBet != null)
            {
                betAmount.Value = betAmount.Minimum;
                betAnimal.Value = betAnimal.Minimum;
            }
            else
            {
                betAmount.Value = betAmount.Minimum;
                betAnimal.Value = betAnimal.Minimum;
            }
        }

        private void rbPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPlayer1.Checked == true)
            {
                SetBettor(0);
            }
            else
            {

            }
        }

        private void rbPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPlayer2.Checked == true)
            {
                SetBettor(1);
            }
            else
            {

            }
        }

        private void rbPlayer3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPlayer3.Checked == true)
            {
                SetBettor(2);
            }
            else
            {

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            do
            {
                for (int i = 0; i < Animals.Length; i++)
                {
                    if(Animals[i].Run())
                    {
                        for (int k = 0; k < Animals.Length; k++)
                        {
                            if (Animals[k].finish)
                            {
                                MessageBox.Show(String.Format("Vis #{0} heeft de race gewonnen!", (k+1)), "Finished", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                for (int j = 0; j < Bettors.Length; j++)
                                {
                                    Bettors[j].Collect(k+1);
                                }
                            }
                        }
                    }
                }
            } while (!Animals[0].finish && !Animals[1].finish && !Animals[2].finish && !Animals[3].finish);
            ResetLocation();
        }

        private void ResetLocation()
        {
            for (int i = 0; i < Animals.Length; i++)
            {
                Animals[i].TakeStartingPosition();
            }
        }

        public void chooseAnimal()
        {
            if (rb_Dolphin.Checked == true)
            {
                animalnum = 1;
            }
            else if (rb_Shark.Checked == true)
            {
                animalnum = 2;
            }
            else
            {
                animalnum = 3;
            }
            AnimalChoice();
        }

        public void AnimalChoice()
        {
            switch (animalnum)
            {
                case 1:
                    pbAnimal1.Image = Properties.Resources.Dolphin;
                    pbAnimal2.Image = Properties.Resources.Dolphin;
                    pbAnimal3.Image = Properties.Resources.Dolphin;
                    pbAnimal4.Image = Properties.Resources.Dolphin;
                    break;
                case 2:
                    pbAnimal1.Image = Properties.Resources.Shark;
                    pbAnimal2.Image = Properties.Resources.Shark;
                    pbAnimal3.Image = Properties.Resources.Shark;
                    pbAnimal4.Image = Properties.Resources.Shark;
                    break;
                case 3:
                    pbAnimal1.Image = Properties.Resources.blackfish;
                    pbAnimal2.Image = Properties.Resources.blackfish;
                    pbAnimal3.Image = Properties.Resources.blackfish;
                    pbAnimal4.Image = Properties.Resources.blackfish;
                    break;
                default:
                    break;
            }
        }

        private void choose_Click(object sender, EventArgs e)
        {
            chooseAnimal();
        }
    }
}
