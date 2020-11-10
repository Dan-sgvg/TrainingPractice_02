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
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();
            listBox1.Items.Add("Кол-во пар:");
            listBox2.Items.Add("Кол-во ходов:");
            listBox3.Items.Add("Время:");

            string path = @"C:\Records";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            using (var fstream = new StreamReader(@"C:\Records\Игра_на_память.txt"))
            {
                string line;
                int counter = 0;
                while ((line = fstream.ReadLine()) != null)
                {
                    if (counter % 3 == 0)
                        listBox1.Items.Add("   " + line);
                    if (counter % 3 == 1)
                        listBox2.Items.Add("   " + line);
                    if (counter % 3 == 2)
                        listBox3.Items.Add("   " + (Convert.ToInt32(line)));
                    counter++;
                }  
            }

            if (listBox1.Items.Count > 2)
            {
                string temp;
                for (int i = 1; i < listBox1.Items.Count-1; i++)
                    for (int j = 1; j < listBox1.Items.Count-1; j++)
                    {
                        if (Convert.ToInt32(listBox1.Items[j]) < Convert.ToInt32(listBox1.Items[j + 1]))
                        {
                            temp = Convert.ToString(listBox1.Items[j]);
                            listBox1.Items[j] = Convert.ToString(listBox1.Items[j + 1]);
                            listBox1.Items[j + 1] = temp;

                            temp = Convert.ToString(listBox2.Items[j]);
                            listBox2.Items[j] = Convert.ToString(listBox2.Items[j + 1]);
                            listBox2.Items[j + 1] = temp;

                            temp = Convert.ToString(listBox3.Items[j]);
                            listBox3.Items[j] = Convert.ToString(listBox3.Items[j + 1]);
                            listBox3.Items[j + 1] = temp;
                        }
                    }
                for (int i = 1; i < listBox3.Items.Count - 1; i++)
                    for (int j = 1; j < listBox3.Items.Count - 1; j++)
                    {
                        if ((Convert.ToInt32(listBox3.Items[j]) > Convert.ToInt32(listBox3.Items[j + 1]))
                            && (Convert.ToInt32(listBox1.Items[j]) == Convert.ToInt32(listBox1.Items[j + 1])) )
                        {

                            temp = Convert.ToString(listBox2.Items[j]);
                            listBox2.Items[j] = Convert.ToString(listBox2.Items[j + 1]);
                            listBox2.Items[j + 1] = temp;

                            temp = Convert.ToString(listBox3.Items[j]);
                            listBox3.Items[j] = Convert.ToString(listBox3.Items[j + 1]);
                            listBox3.Items[j + 1] = temp;
                        }
                    }
            }

            if (listBox1.Items.Count > 10)
                for (int i = (listBox1.Items.Count-1); i >= 11; i--)
                {
                    listBox1.Items.RemoveAt(i);
                    listBox2.Items.RemoveAt(i);
                    listBox3.Items.RemoveAt(i);
                }
            for (int i = 1; i < listBox1.Items.Count; i++)
                listBox3.Items[i] = Convert.ToString("  "+ (Convert.ToInt32(listBox3.Items[i]))/60 + "m " + (Convert.ToInt32(listBox3.Items[i])) % 60 + "s");
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Delete(@"C:\Records\Игра_на_память.txt");
            Environment.Exit(0);
        }
    }
}
