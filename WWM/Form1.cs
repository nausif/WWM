using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WWM
{
    public partial class Form1 : Form
    {
        Form2 F2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            F2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            instructions ins = new instructions();
            this.Hide();
            ins.Show();
        }
    }
}
