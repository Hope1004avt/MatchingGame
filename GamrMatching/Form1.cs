using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamrMatching
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void bEasy_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter the player's name");
            }
            
        }

        private void bRanking_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(tbName.Text);
            f3.ShowDialog();
        }

        private void bMiddle_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter the player's name");
            }
        }

        private void bHard_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter the player's name");
            }
        }
    }
}
