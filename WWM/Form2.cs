using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WWM
{
    public partial class Form2 : Form
    {
        string[] arr = File.ReadAllLines("questions.txt");
        int con = 0;
        FinalAmountWon f3 = new FinalAmountWon();
        
        public void questions()
        {
            btnquestions.Text = arr[con];
            btn1.Text = arr[con + 1];
            btn2.Text = arr[con + 2];
            btn3.Text = arr[con + 3];
            btn4.Text = arr[con + 4];
        }
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            questions();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnActivate();
            if (con == 10)
            {
                con += 5;
                questions();
                label3.BackColor = Color.Green;
            }
            else if (con == 20)
            {
                con += 5;
                questions();
                label5.BackColor = Color.Green;
                f3.TotalAmount.Text = "$ 1000";
            }
            else if (con == 40)
            {
                con += 5;
                questions();
                label9.BackColor = Color.Green;
                
            }
            else
            {
                f3.Show();
                this.Hide();
            }
            
        }
           

        private void btn2_Click(object sender, EventArgs e)
        {
            btnActivate();
            if (con == 0)
            {
                con += 5;
                questions();
                label1.BackColor = Color.Green;
                
            }
            else if (con == 30)
            {
                con += 5;
                questions();
                label7.BackColor = Color.Green;

            }
            else if (con == 35)
            {
                con += 5;
                questions();
                label8.BackColor = Color.Green;

            }
            else if (con == 50)
            {
                con += 5;
                questions();
                label11.BackColor = Color.Green;

            }
            else if (con == 70)
            {
                label15.BackColor = Color.Green;
                f3.TotalAmount.Text = "$ 1,000,000";
                f3.lblwon.Text = "You Won Grand Amount:";
                this.Hide();
                f3.Show();
            }
            else
            {
                f3.Show();
                this.Hide();
            }
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnActivate();
            if (con == 5)
            {
                con += 5;
                questions();
                label2.BackColor = Color.Green;
                
            }
            else if (con == 25)
            {
                con += 5;
                questions();
                label6.BackColor = Color.Green;
            }
            else if (con == 60)
            {
                con += 5;
                questions();
                label13.BackColor = Color.Green;
                
            }
            else
            {
                f3.Show();
                this.Hide();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnActivate();
            if (con == 15)
            {
                con += 5;
                questions();
                label4.BackColor = Color.Green;
                
            }
            else if (con == 45)
            {
                con += 5;
                questions();
                label10.BackColor = Color.Green;
                f3.TotalAmount.Text = "$ 32000";
            }
            else if (con == 55)
            {
                con += 5;
                questions();
                label12.BackColor = Color.Green;
            }
            else if (con == 65)
            {
                con += 5;
                questions();
                label14.BackColor = Color.Green;
            }
            else
            {
                f3.Show();
                this.Hide();
            }
        }

        public void btnActivate()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
        }
        private void btnquite_Click_1(object sender, EventArgs e)
        {
            if (con == 5)
            {
                f3.TotalAmount.Text = "$ 100";
            }
            else if (con == 10)
            {
                f3.TotalAmount.Text = "$ 200";
            }
            else if (con == 15)
            {
                f3.TotalAmount.Text = "$ 300";
            }
            else if (con == 20)
            {
                f3.TotalAmount.Text = "$ 500";
            }
            else if (con == 30)
            {
                f3.TotalAmount.Text = "$ 2000";
            }
            else if (con == 35)
            {
                f3.TotalAmount.Text = "$ 4000";
            }
            else if (con == 40)
            {
                f3.TotalAmount.Text = "$ 8000";
            }
            
            else if (con == 45)
            {
                f3.TotalAmount.Text = "$ 16000";
            }
            else if (con == 55)
            {
                f3.TotalAmount.Text = "$ 64000";
            }
            else if (con == 60)
            {
                f3.TotalAmount.Text = "$ 125000";
            }
            else if (con == 65)
            {
                f3.TotalAmount.Text = "$ 250000";
            }
            else if (con == 70)
            {
                f3.TotalAmount.Text = "$ 500000";
            }
            this.Hide();
            f3.Show();
        }

        private void life2_Click_1(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure you want to use 50 - 50", "Life Line", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                life2.Visible = false;
                life2used.Visible = true;
                if (con == 0)
                {
                    btn3.Text = "";
                    btn4.Text = "";
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                }
                else if (con == 5)
                {
                    btn1.Text = "";
                    btn4.Text = "";
                    btn1.Enabled = false;
                    btn4.Enabled = false;
                }
                else if (con == 10)
                {
                    btn2.Text = "";
                    btn3.Text = "";
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                }
                else if (con == 15)
                {
                    btn2.Text = "";
                    btn3.Text = "";
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                }
                else if (con == 20)
                {
                    btn2.Text = "";
                    btn4.Text = "";
                    btn2.Enabled = false;
                    btn4.Enabled = false;
                }
                else if (con == 25)
                {
                    btn1.Text = "";
                    btn2.Text = "";
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                }
                else if (con == 30)
                {
                    btn3.Text = "";
                    btn4.Text = "";
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                }
                else if (con == 35)
                {
                    btn1.Text = "";
                    btn4.Text = "";
                    btn1.Enabled = false;
                    btn4.Enabled = false;
                }
                else if (con == 40)
                {
                    btn2.Text = "";
                    btn4.Text = "";
                    btn2.Enabled = false;
                    btn4.Enabled = false;
                }
                else if (con == 45)
                {
                    btn1.Text = "";
                    btn3.Text = "";
                    btn1.Enabled = false;
                    btn3.Enabled = false;
                }
                else if (con == 50)
                {
                    btn3.Text = "";
                    btn4.Text = "";
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                }
                else if (con == 55)
                {
                    btn2.Text = "";
                    btn3.Text = "";
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                }
                else if (con == 60)
                {
                    btn2.Text = "";
                    btn4.Text = "";
                    btn2.Enabled = false;
                    btn4.Enabled = false;
                }
                else if (con == 65)
                {
                    btn2.Text = "";
                    btn3.Text = "";
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                }
                else if (con == 70)
                {
                    btn3.Text = "";
                    btn4.Text = "";
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                }
            }
        }

        private void life1_Click_1(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure you want to use Audience Poll", "Life Line", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
            {
                life1.Visible = false;
                life1used.Visible = true;
                if (con == 0)
                {
                    MessageBox.Show("A)- 5%" + "\nB)- 75%" + "\nC)- 10%" + "\nD)- 10%", "audience poll :", MessageBoxButtons.OK);

                }
                else if (con == 5)
                {
                    MessageBox.Show("A)- 20%" + "\nB)- 10%" + "\nC)- 65%" + "\nD)- 5%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 10)
                {
                    MessageBox.Show("A)- 80%" + "\nB)- 10%" + "\nC)- 5%" + "\nD)- 5%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 15)
                {
                    MessageBox.Show("A)- 5%" + "\nB)- 10%" + "\nC)- 35%" + "\nD)- 50%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 20)
                {
                    MessageBox.Show("A)- 60%" + "\nB)- 20%" + "\nC)- 10%" + "\nD)- 10%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 25)
                {
                    MessageBox.Show("A)- 40%" + "\nB)- 15%" + "\nC)- 40%" + "\nD)- 5%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 30)
                {
                    MessageBox.Show("A)- 15%" + "\nB)- 40%" + "\nC)- 10%" + "\nD)- 35%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 35)
                {
                    MessageBox.Show("A)- 20%" + "\nB)- 35%" + "\nC)- 35%" + "\nD)- 10%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 40)
                {
                    MessageBox.Show("A)- 20%" + "\nB)- 25%" + "\nC)- 30%" + "\nD)- 25%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 45)
                {
                    MessageBox.Show("A)- 10%" + "\nB)- 20%" + "\nC)- 30%" + "\nD)- 40%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 50)
                {
                    MessageBox.Show("A)- 25%" + "\nB)- 35%" + "\nC)- 15%" + "\nD)- 25%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 55)
                {
                    MessageBox.Show("A)- 15%" + "\nB)- 40%" + "\nC)- 5%" + "\nD)- 40%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 60)
                {
                    MessageBox.Show("A)- 30%" + "\nB)- 20%" + "\nC)- 40%" + "\nD)- 10%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 65)
                {
                    MessageBox.Show("A)- 25%" + "\nB)- 15%" + "\nC)- 30%" + "\nD)- 30%", "audience poll :", MessageBoxButtons.OK);
                }
                else if (con == 70)
                {
                    MessageBox.Show("A)- 30%" + "\nB)- 35%" + "\nC)- 30%" + "\nD)- 5%", "audience poll :", MessageBoxButtons.OK);
                }
                
            }
        }
    }
}
