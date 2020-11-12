using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrainingPractice_02
{
    public partial class Form2 : Form
    {
        private static void Shuffle<T>(IList<T> arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                var rndInd = rnd.Next(0, arr.Count());
                var rndInd2 = rnd.Next(0, arr.Count());
                var temp = arr[rndInd];
                arr[rndInd] = arr[rndInd2];
                arr[rndInd2] = temp;
            }
        }

        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        static List<int> pairs = new List<int>();
        static int group_order;


        private void Any_button_Click(object sender, EventArgs e)
        {
            group_order++;

            if (group_order == 1)
            {
                foreach (var button in Controls.OfType<Button>())
                {
                    button.Text = "?";
                    button.BackgroundImage = null;
                }

                first_button_tab_index.Text = Convert.ToString((sender as Button).Name); 
                foreach (int element in pairs) 
                {
                    if ( pairs[element] == Convert.ToInt32((sender as Button).Name)) 
                    {
                        place_in_list1.Text = Convert.ToString(element);
                        if (element % 2 == 0)
                        {
                            wanted_result.Text = Convert.ToString(pairs[element + 1]);
                            (sender as Button).Text = "";
                            string path = Convert.ToString(pairs[Convert.ToInt32(place_in_list1.Text)]);
                            (sender as Button).BackgroundImage = Image.FromFile($@"pictures\{path}.jpg", false);
                            (sender as Button).BackgroundImageLayout = ImageLayout.Center;
                        }
                            
                        else
                        {
                            wanted_result.Text = Convert.ToString(pairs[element - 1]);
                            (sender as Button).Text = "";
                            string path = Convert.ToString(pairs[(Convert.ToInt32(place_in_list1.Text)) - 1]);
                            (sender as Button).BackgroundImage = Image.FromFile($@"pictures\{path}.jpg", false);
                            (sender as Button).BackgroundImageLayout = ImageLayout.Center;
                        }
                        break;
                    }

                }
                
            }
            else
            {
                second_button_tab_index.Text = Convert.ToString((sender as Button).Name);
                group_order = 0;

                foreach (int element in pairs)
                {
                    if (pairs[element] == Convert.ToInt32((sender as Button).Name))
                    {
                        place_in_list2.Text = Convert.ToString(element);
                        
                        if (element % 2 == 0)
                        {
                            (sender as Button).Text = "";
                            string path = Convert.ToString(pairs[Convert.ToInt32(place_in_list2.Text)]);
                            (sender as Button).BackgroundImage = Image.FromFile($@"pictures\{path}.jpg", false);
                            (sender as Button).BackgroundImageLayout = ImageLayout.Center;
                        }
                        else
                        {
                            (sender as Button).Text = "";
                            string path = Convert.ToString(pairs[(Convert.ToInt32(place_in_list2.Text)) - 1]);
                            (sender as Button).BackgroundImage = Image.FromFile($@"pictures\{path}.jpg", false);
                            (sender as Button).BackgroundImageLayout = ImageLayout.Center;
                        }
                        break;
                    }   
                }

                if (second_button_tab_index.Text == wanted_result.Text) 
                {
                    foreach (var button in Controls.OfType<Button>())
                    {
                        if ( ( (Convert.ToInt32(button.Name) ) == (Convert.ToInt32(first_button_tab_index.Text) ) ) 
                        || ( ( (Convert.ToInt32(button.Name) ) == (Convert.ToInt32(second_button_tab_index.Text) ) ) ) )
                        {
                            Controls.Remove(button);
                        }

                    }
                    foreach (var button in Controls.OfType<Button>())
                    {
                        if (((Convert.ToInt32(button.Name)) == (Convert.ToInt32(first_button_tab_index.Text)))
                        || (((Convert.ToInt32(button.Name)) == (Convert.ToInt32(second_button_tab_index.Text)))))
                        {
                            Controls.Remove(button);
                        }

                    }
                    textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + 1);
                }
                else
                    textBox2.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + 1);
            }

            int num_of_buttons = 0;
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    num_of_buttons++;
                }
            }
            if (num_of_buttons == 0)
            {
                timer1.Stop();
                var result = MessageBox.Show($"Вы завершили игру с общим временем:{Convert.ToInt32(textBox1.Text)} секунд," +
                        $"\nи количеством ходов равным:{Convert.ToInt32(textBox2.Text)}\nСохранить результат?","Поздравляю!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string path = @"Records";
                    DirectoryInfo dirInfo = new DirectoryInfo(path);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }
                    using (FileStream fstream = new FileStream(@"Records\Игра_на_память.txt", FileMode.Append))
                    {
                        byte[] array = System.Text.Encoding.Default.GetBytes(" " + Convert.ToString(Convert.ToInt32(label1.Text)/2)+ "\n");
                        fstream.Write(array, 0, array.Length);

                        

                        array = System.Text.Encoding.Default.GetBytes(" "+textBox2.Text + "\n");
                        fstream.Write(array, 0, array.Length);

                        array = System.Text.Encoding.Default.GetBytes(" " + textBox1.Text + "\n");
                        fstream.Write(array, 0, array.Length);
                        
                        if (fstream != null)
                            fstream.Close();
                    }
                    


                }
                    
                Environment.Exit(0);
            }
                
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + 1);
            
            if (Convert.ToInt32(textBox1.Text) == 1)
            {
                group_order = 0;
                int y = 100; int x = 30; int tab_index = 0; int button_number = 0;

                for (int i = 0; i < (Convert.ToInt32(label1.Text)); i++)
                {
                    if (i % 5 == 0 && i != 0)
                    {
                        y += 65;
                        x = 30;
                    }
                        
                    Button button = new Button();
                    button.Left = x;
                    button.Top = y;
                    button.Width = 75;
                    button.Height = 60;
                    button.Text = "?";
                    button.Name = Convert.ToString(button_number);
                    button.TabIndex = tab_index;
                    this.Controls.Add(button);

                    button.Click += Any_button_Click;
                    button_number++;
                    tab_index++;
                    pairs.Add(i);
                    x += 80;
                }
                Shuffle(pairs);
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            label5.Text = ""; int i = 0;
            foreach (int element in pairs)
            {
                if (i % 2 == 0)
                    label5.Text += i + "-"+ (i+1) + " [" + element;
                else
                    label5.Text +=  " " + element + " ]";
                i ++;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
