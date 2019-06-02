using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JackPot
{
    /// <summary>
    /// Controlers of the veiw
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //when the button is clicked
        private void BtnFind_Click(object sender, EventArgs e)
        {
            try
            {
                //fetch textbox values
                int no1 = int.Parse(txtNo1.Text);
                int no2 = int.Parse(txtNo2.Text);
                int no3 = int.Parse(txtNo3.Text);

                //create a new object of Spin
                var sp = new Spin();

                //check the boolean value --> Spin class
                bool isNo1 = sp.Match(no1);
                bool isNo2 = sp.Match(no2);
                bool isNo3 = sp.Match(no3);

                //clear option
                if(btnFind.Text == "Clear All")
                {
                    //clear all text boxes
                    txtNo1.Text = "";
                    txtNo2.Text = "";
                    txtNo3.Text = "";

                    //state to the default values
                    lblDisplay.ForeColor = Color.Black;
                    lblDisplay.Text = "Pending ...";

                    //state to the default values
                    btnFind.ForeColor = Color.Black;
                    btnFind.Text = "Find Your Luck!";
                }
                //match numbers with the array
                else if(btnFind.Text == "Find Your Luck!")
                {
                    //when match all three numbers
                    if (isNo1 && isNo2 && isNo3)
                    {
                        lblDisplay.ForeColor = Color.Green;
                        lblDisplay.Text = "Hooray! You win $10000.00";
                    }
                    //when match atleast two numbers
                    else if ((isNo1 && isNo2) || (isNo1 && isNo3) || (isNo2 && isNo3))
                    {
                        lblDisplay.ForeColor = Color.Orange;
                        lblDisplay.Text = "Hooray! You win $100.00";
                    }
                    //when match only one number
                    else if (isNo1 || isNo2 || isNo3)
                    {
                        lblDisplay.ForeColor = Color.DarkOrange;
                        lblDisplay.Text = "Hooray! You win $10.00";
                    }
                    //when all numbers are not matching
                    else
                    {
                        lblDisplay.ForeColor = Color.Red;
                        lblDisplay.Text = "Oopz! Better luck next time ...";
                    }

                    //set button to clear state once get the results
                    btnFind.ForeColor = Color.Red;
                    btnFind.Text = "Clear All";

                }

            }
            //if the text input gone wrong
            catch
            {
                lblDisplay.Text = "ERROR: Invalid Input";
                txtNo1.Text = "";
                txtNo2.Text = "";
                txtNo3.Text = "";

                //set button to the default state
                btnFind.ForeColor = Color.Black;
                btnFind.Text = "Find Your Luck!";
            }

        }
    }
}
