using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7_1Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str;

            try
            {
                str = textBoxArea.Text;
                if (str.Length == 0) throw new Exception("Пустая строка. Введите что нибудь!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = 0;
            int lastColonIndex = -1;
            for (int i = str.Length - 1; lastColonIndex < 0 ? i >= 0 : i < str.Length - 1;)
            {
                if (str[i] == ':')
                {
                    lastColonIndex = i;
                }
                if (lastColonIndex > 0)
                {
                    i++;
                    MessageBox.Show(str[i].ToString());
                }
                else
                    i--;
            }

            if (count == 0)
            {
                MessageBox.Show("Нет двоеточия");
            }
            textBoxRes.Text = str.ToString();
        }
    }
}
