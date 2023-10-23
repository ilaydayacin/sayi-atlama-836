using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adım_atlamalı_for_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            int basla, bitir, atlama;
            basla = Convert.ToInt32(txtBasla.Text);
            bitir = Convert.ToInt32(txtBitir.Text);
            atlama = Convert.ToInt32(txtAtlama.Text);

            for (int i = basla; i <= bitir; i=i+atlama)
            {
                lbSayilar.Items.Add(i);
            }

        }
    }
}
