using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi;
        Random rnd = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = rnd.Next(0,100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilensayi = Convert.ToInt32(textBox1.Text);

            if (sayi == girilensayi)
            {
                label2.Text = "Doğru Sayı!";
            }
            if(sayi<girilensayi)
            {
                label2.Text="Daha Küçük Sayı Tahmin Et!";
            }
            if (sayi > girilensayi)
            {
                    label2.Text="Daha Büyük Sayı Tahmin Et!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
