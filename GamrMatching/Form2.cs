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
    public partial class Form2 : Form
    {

        Random random = new Random();

        // Лист со списком значений карточек
        List<string> icons = new List<string>()
        {
            "a", "a", "b", "b", "c", "c", "d", "d", "g", "g", "^", "^", "h", "h", "i", "i"
        };

        int Count = 0;

        // Метка укаывающая на первое нажатие
        Label firstClicked = null;

        // Метка указывающая на второе нажатие
        Label secondClicked = null;

        public Form2()
        {
            InitializeComponent();

            AssignIconsToSquares();
        }

        // Увеличение счетчика ходов и обновление метки в форме
        private void IncrementMovesCount()
        {
            Count++;
            lCount.Text = Count.ToString();
        }

        // Обработчик клика по иконке
        private void label1_Click(object sender, EventArgs e)
        {
            
            if (timer1.Enabled == true)
            {
                return;
            }

            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                
                if(clickedLabel.ForeColor == Color.FromArgb(128, 128, 255))
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
                IncrementMovesCount();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }

        // Проверка неоткрытых иконок
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
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
                MessageBox.Show("You win!!! Count: " + Count);
                Close();
        }

        // Назначение каждому квадрату случайный элемент из списка 
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
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

        // Запускается когда игрок нажимает две не совпадающие иконки, затем отсчитывается 3 секунды и выключается.
        // после обе иконки скрываются
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        System.Timers.Timer Timer;
        int m, s;

        private void Form2_Load(object sender, EventArgs e)
        {
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000; // 1s
            Timer.Elapsed += OnTimeEvent;
            Timer.Start();

            tbTime.ReadOnly = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer.Stop();
            Timer.Dispose();
        }

        // подсчет времени
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Проверяем что форма еще не закрыта
            if (!IsDisposed)
            {
                Invoke((MethodInvoker)(() =>
                {
                    s = s + 1;
                    if (s == 60)
                    {
                        s = 0;
                        m = m + 1;
                    }
                    tbTime.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));

                    if (m == 2)
                    {
                        Timer.Stop();
                        MessageBox.Show("You lose!");
                    }

                }));
                
            }
            string Result = tbTime.Text;
            int minut = m;
        }


    }
}
