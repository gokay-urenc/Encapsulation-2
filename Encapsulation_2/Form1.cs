using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kisi k = new Kisi();
            k.adi = "Negan";
            k.soyadi = "Lucille";
            k.Yas = 52; // Değeri Yas'a set ettik.
            MessageBox.Show(k.adi);
            MessageBox.Show(k.Yas.ToString()); // Yas'ı get ettik.

            Kisi k2 = new Kisi();
            k2.adi = "Rick";
            k2.soyadi = "Grimes";
            k2.Yas = 47;
        }
    }
}
