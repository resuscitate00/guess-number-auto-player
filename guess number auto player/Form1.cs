using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess_number_auto_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            int min = 100, max = 999, c = 1, num = 0;
            num = (min + max) / 2;

            Random rd = new Random();
            int rnd = rd.Next(100, 999);


            while (num != rnd)
            {
                if (num > rnd)
                {
                    max = num; num = (num + min) / 2;
                }
                else if (num < rnd)
                {
                    min = num; num = (num + max) / 2;
                }
                listBox1.Items.Add(num);
                c++;
                label1.Text = "round : " + c.ToString();
            }
            label2.Text = "random number: " + num;
            button1.Enabled = false;
            MessageBox.Show("win");
        }
    }
}