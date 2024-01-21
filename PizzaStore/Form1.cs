using System;

using System.Drawing;

using System.Windows.Forms;

namespace PizzaStore
{
    public partial class Form1 : Form
    {
        public int TotalPrice = 0;

        public string Toppings1 = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
            {
                TotalPrice += 30;
                lbSizeValue.Text = rbSmall.Text;

            }
            else
                TotalPrice -= 30;

            PriceValue.Text = TotalPrice.ToString();

        }

        private void rbMidum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMidum.Checked)
            {
            TotalPrice += 60;
            lbSizeValue.Text = rbMidum.Text;

            }
            else
                TotalPrice -= 60;

            PriceValue.Text = TotalPrice.ToString();


        }

        private void rbBig_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBig.Checked)
            {
                TotalPrice += 90;
                lbSizeValue.Text = rbBig.Text;

            }
            else
                TotalPrice -= 90;

            PriceValue.Text = TotalPrice.ToString();

        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThin.Checked)
            {
                TotalPrice *= 1;
                lbCrustValue.Text = rbThin.Text;

            }
            PriceValue.Text = TotalPrice.ToString();


        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbThink.Checked)
            {
                TotalPrice += 50;
                lbCrustValue.Text = rbThink.Text;
            }
            else
                TotalPrice -= 50;

            PriceValue.Text = TotalPrice.ToString();

        }

      

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            
            lbWhereToEat.Text = rbEatIn.Text;

        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTakeOut.Checked)
            {
                TotalPrice +=  50;
                lbWhereToEat.Text = rbTakeOut.Text;
            }
            else
                TotalPrice -= 50;

            PriceValue.Text = TotalPrice.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TotalPrice += 10;
                line1toppings.Text = Toppings1 += "chees, ";
            }
            else
            {
                TotalPrice -= 10;

            }

            PriceValue.Text = TotalPrice.ToString();

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                TotalPrice += 10;
                // lbonion.Text = "    Oinio ";
                line1toppings.Text = Toppings1 += "onion, ";

            }
            else
            {
                TotalPrice -= 10;                
               // lbonion.Text = " ";

            }

            PriceValue.Text = TotalPrice.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                TotalPrice += 10;
                line1toppings.Text = Toppings1 += "mushrooms, ";
            }
            else
            {
                TotalPrice -= 10;                

            }

            PriceValue.Text = TotalPrice.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                TotalPrice += 10;
                line1toppings.Text = Toppings1 += "olives, ";
            }
            else
            {
                TotalPrice -= 10;                
            }

            PriceValue.Text = TotalPrice.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                TotalPrice += 10;
                line1toppings.Text = Toppings1 += "green Pepper, ";

            }
            else
            {
                TotalPrice -= 10;

            }

            PriceValue.Text = TotalPrice.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                TotalPrice += 10;
                line1toppings.Text = Toppings1 += "tomatos, ";
            }
            else
            {
                TotalPrice -= 10;

            }

            PriceValue.Text = TotalPrice.ToString();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Number " + PhoneTextBox.Text + "\nAdress " + AdressTextBox.Text + "\nPrice " + TotalPrice + $"\nExpected Time {5} mins", "Ur Order",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

    
        private void button2_Click_1(object sender, EventArgs e)
        {
            PhoneTextBox.Text = "";
            AdressTextBox.Text = "";
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            lbSizeValue.BackColor = Color.Transparent;
            lbCrustValue.BackColor = Color.Transparent;
            lbWhereToEat.BackColor = Color.Transparent;
            line1toppings.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox4.BackColor = Color.Transparent;
            groupBox5.BackColor = Color.Transparent;
            GBToppings.BackColor = Color.Transparent;




            PriceValue.BackColor = Color.Transparent;
         
        }
    }
}
