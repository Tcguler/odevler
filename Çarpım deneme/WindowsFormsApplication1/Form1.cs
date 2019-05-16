using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       
        Random salla = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        bool Matris_Al(string str, int[,] dizi)
        {
            string[] s;
            char[] bölücüler = { ' ', '\r' };
            s = str.Split(bölücüler);   
            if (s.GetUpperBound(0) < (Convert.ToInt32(txtSatir.Text) * Convert.ToInt32(txtSutun.Text) ) );
{
    MessageBox.Show("Matris yanlış girilmiştir");
return false;
}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtSatir.Text);
            int y = Convert.ToInt32(txtSutun.Text);
            int[,] a = new int[x, y];
            int[,] b = new int[x, y];
            int[,] c = new int[x, y];
            int s = 0; 

            Matris_Al(MatrisA.Text, a);
            Matris_Al(MatrisB.Text, b);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    s = 0;
                    for (int k = 0; k < x; k++)
                    {
                        s = s + a[i, k] * b[k, i];
                    }
                    c[i, j] = s;
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    txtSonuc.Text = txtSonuc.Text + " " + c[i, j].ToString();
                }
                txtSonuc.Text += "\r\n";
            }
        }
    }
}