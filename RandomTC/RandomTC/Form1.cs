using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomTC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            Random rnd = new Random();
            int b = Convert.ToInt32(textBox1.Text);

            
            for (int a = 0; a < b; a++)
            {
                sayac += 1;
                int[] dizi = new int[9];
                for (int j = 0; j < 11; j++)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        dizi[i] = rnd.Next(0, 10);
                        if (dizi[0] == 0)
                            i--;
                    }
                }

                string tcKimlik = dizi.Aggregate("", (current, t) => current + t);
                int tekBasamakToplam = 0;
                int ciftBasamakToplam = 0;
                int tekilHesap;
                for (int i = 0; i < 9; i += 2)
                    tekBasamakToplam += int.Parse(tcKimlik.Substring(i, 1));
                for (int i = 1; i < 9; i += 2)
                    ciftBasamakToplam += int.Parse(tcKimlik.Substring(i, 1));
                tekilHesap = ((tekBasamakToplam * 7) - ciftBasamakToplam) % 10;
                tcKimlik += Convert.ToInt32(tekilHesap);
                int toplam = 0;

                for (int i = 0; i < 10; i++)
                {
                    byte toplanacakSayi = byte.Parse(tcKimlik.Substring(i, 1));
                    toplam += toplanacakSayi;
                    toplam %= 10;
                }
                tcKimlik += Convert.ToInt32(toplam);

                listBox1.Items.Add(tcKimlik);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
