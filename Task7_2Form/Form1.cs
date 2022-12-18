using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7_2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Empty;

            str = textBoxArea.Text;

            string[] words = str.Split(' ');

            List<string> result = new List<string>();

            try
            {
                if (string.IsNullOrWhiteSpace(str)) throw new Exception("Пустая строка!!");

                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    int count = 0;

                    foreach (string w in words)
                        if (w == word) count++;

                    if (count == 1) result.Add(word);
                }

                if (result.Count == 0) throw new Exception("Нет слов!");

                foreach (string item in result)
                    textBoxRes.Text += item;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
