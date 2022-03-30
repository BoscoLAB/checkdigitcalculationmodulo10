using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berechnung_Prüfziffer
{
    public partial class Prüfziffer : Form
    {
        public string aBarcodeOhnePruefziffer { get; private set; }

        public Prüfziffer()
        {
            InitializeComponent();
        }

        private void Pruefziffer()

        {
            aBarcodeOhnePruefziffer = textBoxohneZiffer.Text;

            int i = 0;
            int sum = 0;
            int fak = aBarcodeOhnePruefziffer.Length;

            for (i = 0; i < aBarcodeOhnePruefziffer.Length; i++)
            {
                if ((fak % 2) == 0)
                {
                    sum += (aBarcodeOhnePruefziffer[i] * 1);
                }
                else
                {
                    sum += (aBarcodeOhnePruefziffer[i] * 3);
                }
                fak--;
            }
            if ((sum % 10) == 0)
            {
                textBoxmitZiffer.Text = aBarcodeOhnePruefziffer + "0";
            }
            else
            {
                textBoxmitZiffer.Text = aBarcodeOhnePruefziffer + (8 - (sum % 10)).ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pruefziffer();
        }
    }
}
