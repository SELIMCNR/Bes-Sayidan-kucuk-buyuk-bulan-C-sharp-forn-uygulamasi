using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirilenOnSayidanBuyukKucukBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sayi1, sayi2, sayi3,sayi4,sayi5;
            int enBuyuk, enKucuk;
            sayi1 = Convert.ToInt32(TxtSayı1.Text);
            sayi2 = Convert.ToInt32(TxtSayi2.Text);
            sayi3 = Convert.ToInt32(TxtSayi3.Text);
            sayi4= Convert.ToInt32(TxtSayi4.Text);
            sayi5 = Convert.ToInt32(TxtSayi5.Text);

            if(sayi1>sayi2 && sayi1>sayi3 && sayi1>sayi4 && sayi1>sayi5)
            {
                enBuyuk = sayi1;
            }
            else if (sayi2>sayi1 && sayi2>sayi3 && sayi2>sayi4 && sayi2>sayi5)  
            {
                enBuyuk= sayi2;
            }
            else if (sayi3>sayi1 && sayi3>sayi2 && sayi3>sayi4 && sayi3>sayi5)
            {
                enBuyuk = sayi3;
            }
            else if (sayi4>sayi1 && sayi4>sayi2 && sayi4 > sayi3 && sayi4 > sayi5)
            {
                enBuyuk = sayi4;
            }
            else
            {
                enBuyuk = sayi5;
            }

            Txt_buyuk.Text = enBuyuk.ToString();

            if (sayi1 < sayi2 && sayi1 < sayi3 && sayi1 < sayi4 && sayi1 < sayi5)
            {
                enKucuk = sayi1;
            }
            else if (sayi2 < sayi1 && sayi2 < sayi3 && sayi2 < sayi4 && sayi2 < sayi5)
            {
                enKucuk = sayi2;
            }
            else if (sayi3 < sayi1 && sayi3 < sayi2 && sayi3 < sayi4 && sayi3 < sayi5)
            {
                enKucuk = sayi3;
            }
            else if (sayi4 < sayi1 && sayi4 < sayi2 && sayi4 < sayi3 && sayi4 < sayi5)
            {
                enKucuk = sayi4;
            }
            else 
            {
                enKucuk = sayi5;
            }
            Txt_kucuk.Text = enKucuk.ToString();
          


        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            sayac++;
            if(sayac %2 == 0)
            {
                label8.BackColor = Color.Aqua;
            }
            else
            {
                label8.BackColor = Color.Yellow;
            }
        }
    }
}
