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
    public partial class Form3 : Form
    {
        private string playerName;

        public Form3(string playerName)
        {
            InitializeComponent();
            this.playerName = playerName;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(playerName); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
