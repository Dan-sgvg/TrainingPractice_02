using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingPractice_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Введите количество пар плиток \nи нажмите начать:";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             
            if (textBox1.Text != "" && Convert.ToInt32(textBox1.Text) <= 10 && Convert.ToInt32(textBox1.Text) > 0)
            {
                Form2 fm2 = new Form2();
                fm2.label1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text)*2);
                this.Hide();
                fm2.Show();

            }
            
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (System.IO.File.Exists(@"Records\Игра_на_память.txt"))
            {
                Form3 fm3 = new Form3();
                this.Hide();
                fm3.Show();
            }
            else
                MessageBox.Show("Вы еще не поставили ни одного рекорда.","Рекордов нет.");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра представляет собой набор из пар одинаковых карточек.\n" +
                "Суть игры очень простая. Эти карточки выкладываются «рубашкой» вверх. Далее игрок открывает две любые карточки, показывая их.\n" +
                "Если на них изображены одинаковые рисунки, они исчезают, и игрок вскрывает следующую пару.\n" +
                "Однако, если изображения разные, то он возвращает эти карточки в закрытую обратно на свои места. ", "Об игре");
        }
    }
}
