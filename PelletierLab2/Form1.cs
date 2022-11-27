using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PelletierLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Jared Pelletier
         * Oct 4 2022
         * This lab is meant to calculate a multiplcation question for you and gives an image as well as
         * data for a topic*/


        private void btnExi_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            //show the picture
            picRel.Visible = true;

            //hide the label behind the picturebox
            picRel.BringToFront();
        }

        private void btnHid_Click(object sender, EventArgs e)
        {
            //hide the picturebox and label
            picRel.Visible = false;
            lblDat.Visible = false;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            //Blank out the text boxes
            txtNum.Text = "";
            txtMul.Text = "";
            lblRes.Text = "";

            //put the cursor on top textbox
            txtNum.Focus();

        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            //update data label 
            lblDat.Text = "My topic is " + (lblRel.Text) + ". The picture shown is my close friend liams cat. \n" +
                "Relic is the sweetest cat I have ever met and I am not a cat person so that means a lot. \n" +
                "\n The first time I got to meet this absolute sweetheart she instantly came up to me trusted me right away." +
                "Usually pets take time to trust someone but not this kitty, she was all for scratches right away.\n" +
                "\n Relic is the sole reason that I can say that I like cats. " + "She is such a caring animal, " +
                "she is the perfect pet and my friend Liam is lucky to have her. ";

            //hide the picture and show label
            picRel.Visible = false;
            lblDat.Visible = true;
            lblDat.BringToFront();
        }

        private void picRel_Click(object sender, EventArgs e)
        {
            //show message box
            MessageBox.Show("This picture was taken by my friends mom Melissa." , "Jared Pelletier");
        }

                private void btnCal_Click(object sender, EventArgs e)
        {
            //create 3 local integer variables
            int number, multiplier, answer;

            //grabbing text box content for variables - conversion 
            number = Convert.ToInt32(txtNum.Text);
            multiplier = Convert.ToInt32(txtMul.Text);

            // do the math
            answer = number * multiplier;

            //convert and then show answer variable as text
            lblRes.Text = answer.ToString();



        }
    }
}
