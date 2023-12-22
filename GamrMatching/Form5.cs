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
    public partial class Form5 : Form
    {

        Random random = new Random();

        // Лист со списком значений карточек
        List<string> icons = new List<string>()
        {
            "j", "j", "k", "k", "l", "l"
        };

        public int count = 0;

        // Метка укаывающая на первое нажатие
        Label firstClicked = null;

        // Метка указывающая на второе нажатие
        Label secondClicked = null;

        public Form5()
        {
            InitializeComponent();

        }

        // Обработчик клика по иконке
        private void label1_Click(object sender, EventArgs e)
        {

            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {

                if (clickedLabel.ForeColor == Color.FromArgb(128, 128, 255))
                {
                    return;
                }

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    clickedLabel.ForeColor = Color.FromArgb(128, 128, 255);
                    return;
                }

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.FromArgb(128, 128, 255);

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

            }
        }

        // Проверка неоткрытых иконок
        private void CheckForWinner()
        {
            foreach (Control control in tlpEasy.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    {
                        return;
                    }
                }
            }
            MessageBox.Show("You win!!!");
            Close();
        }

        // Назначение каждому квадрату случайный элемент из списка 
        private void AssignIconsToSquares()
        {
            foreach (Control control in tlpEasy.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
