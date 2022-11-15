using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asalSayilariBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            long sayac = 0;
            long x = long.Parse(textBox1.Text);
            listBox1.Items.Clear();
            if (x<2)
            {
                MessageBox.Show("Asal Sayı Bulunamadı");

            }
            else
            {
                for (long i=2; i<=x; i++)
                {
                    long kontrol = 0;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        { 
                        kontrol++;
                        break;
                        }

                    }
                    if (kontrol == 0)
                    {
                        listBox1.Items.Add(i);
                        sayac++;
                    }
                } 
                MessageBox.Show("1 - " + x + " arasında " + sayac + " adet asal sayı bulundu.");
            }
            
        }
    }
}
