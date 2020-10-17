using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chpt9
{


    public partial class Form1 : Form
    {
        int[] cardNumber = new int[52];
        int cardIndex;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PicPlayer_Click(object sender, EventArgs e)
        {

        }

        private void PicDiamond_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "Exit")
            {
                this.Close();
            }
            else
            {
                txtOver.Visible = true;
                btnExit.Text = "Exit";
                btnNew.Text = "New Game";
            }
            
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Random myRandom = new Random();
            int yourNumber = 0;
            int comNumber = 0;
            if (btnNew.Text == "New Game")
            {
                txtOver.Visible = false;
                btnNew.Text = "Next Card";
                btnExit.Text = "Stop!";
                txtYourScore.Text = "0";
                txtComScore.Text = "0";
                cardIndex = 0;
            }
            for (int i = 0; i < 52; i++)
            {
                cardNumber[i] = i;
            }
            for (int rem = 52; rem >= 1; rem--)
            {
                int itemPicked = myRandom.Next(rem);
                int temp = cardNumber[itemPicked];
                cardNumber[itemPicked] = cardNumber[rem - 1];
                cardNumber[rem - 1] = temp;
            }
  
            if (cardNumber[cardIndex] >= 0 && cardNumber[cardIndex] <= 12)
            {
                picPlayer.Image = picHeart.Image;
                yourNumber = cardNumber[cardIndex];
            }
            else if (cardNumber[cardIndex] >= 13 && cardNumber[cardIndex] <= 25)
            {
                picPlayer.Image = picDiamond.Image;
                yourNumber = cardNumber[cardIndex] - 13;
            }
            else if (cardNumber[cardIndex] >= 26 && cardNumber[cardIndex] <= 38)
            {
                picPlayer.Image = picClub.Image;
                yourNumber = cardNumber[cardIndex] - 26;
            }
            else if (cardNumber[cardIndex] >= 39 && cardNumber[cardIndex] <= 51)
            {
                picPlayer.Image = picSpade.Image;
                yourNumber = cardNumber[cardIndex] - 39;
            }
            switch (yourNumber)
            {
                //so you know if it's any of the "royal" cards
                case 9:
                    lblPlayer.Text = "J";
                    break;
                case 10:
                    lblPlayer.Text = "Q";
                    break;
                case 11:
                    lblPlayer.Text = "K";
                    break;
                case 12:
                    lblPlayer.Text = "A";
                    break;
                default:
                    lblPlayer.Text = Convert.ToString(yourNumber + 2) + " ";
                    break;
            }
            if (cardNumber[cardIndex + 26] >= 0 && cardNumber[cardIndex + 26] <= 12)
            {
                picComputer.Image = picHeart.Image;
                comNumber = cardNumber[cardIndex + 26];
            }
            else if (cardNumber[cardIndex + 26] >= 13 && cardNumber[cardIndex + 26] <= 25)
            {
                picComputer.Image = picDiamond.Image;
                comNumber = cardNumber[cardIndex + 26] - 13;
            }
            else if (cardNumber[cardIndex + 26] >= 26 && cardNumber[cardIndex + 26] <= 38)
            {
                picComputer.Image = picClub.Image;
                comNumber = cardNumber[cardIndex + 26] - 26;
            }
            else if (cardNumber[cardIndex + 26] >= 39 && cardNumber[cardIndex + 26] <= 51)
            {
                picComputer.Image = picSpade.Image;
                comNumber = cardNumber[cardIndex + 26] - 39;
            }
            switch (comNumber)
            {
                case 9:
                    lblComputer.Text = "J";
                    break;
                case 10:
                    lblComputer.Text = "Q";
                    break;
                case 11:
                    lblComputer.Text = "K";
                    break;
                case 12:
                    lblComputer.Text = "A";
                    break;
                default:
                    lblComputer.Text = Convert.ToString(comNumber + 2) + " ";
                    break;
            }
            if (yourNumber > comNumber)
            {
                //u win
                txtYourScore.Text = Convert.ToString(Convert.ToInt32(txtYourScore.Text) + 2);
            }
            else if (comNumber > yourNumber)
            {
                //com win
                //these are the only comments you are gonna get
                txtComScore.Text = Convert.ToString(Convert.ToInt32(txtComScore.Text) + 2);
            }
            else
            {
                //ok fine
                //tie
                txtYourScore.Text = Convert.ToString(Convert.ToInt32(txtYourScore.Text) + 1);
                txtComScore.Text = Convert.ToString(Convert.ToInt32(txtComScore.Text) + 1);
            }
            cardIndex = cardIndex + 1;
            debug.Text = "Cards Used: " + Convert.ToString(cardIndex);
            if (cardIndex >= 25)
            {
                //all cards used; game over
                txtOver.Visible = true;
                btnNew.Text = "New Game";
                btnExit.Text = "Exit";
            }
        }

        private void LblPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
