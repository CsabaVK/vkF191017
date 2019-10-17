using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _10_16
{
    public partial class FrmMain : Form
    {
        class Vendeg
        {
            public string Nev { get; set; }
            public bool Fiu { get; set; }
            public int Asztal { get; set; }
            public bool Vega { get; set; }

            public Vendeg(string sor)
            {
                var t = sor.Split(';');
                Nev = t[0];
                Fiu = (t[1] == "m");
                Asztal = int.Parse(t[2]);
                Vega = (t[3] == "v");
            }
        }

        List<Vendeg> vendegek;

        public FrmMain()
        {
            InitializeComponent();
            Beolvas();
            CBNevekFeltölt();
        }

        private void CBNevekFeltölt()
        {
            foreach (var v in vendegek)
            {
                comboBox1.Items.Add(v.Nev);
            }
        }

        private void Beolvas()
        {
            vendegek = new List<Vendeg>();
            var sr = new StreamReader("vendegek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                vendegek.Add(new Vendeg(sr.ReadLine()));
                
            }
            sr.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_asztal.Text = vendegek[comboBox1.SelectedIndex].Asztal + " . asztal";
            lb_kaja.Text = vendegek[comboBox1.SelectedIndex].Vega ? "vega" : "hús";
        }
    }
}
