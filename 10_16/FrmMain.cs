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
                cb_nev.Items.Add(v.Nev);
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

        private void cb_nev_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_asztal.Text = vendegek[cb_nev.SelectedIndex].Asztal + " . asztal";
            lb_kaja.Text = vendegek[cb_nev.SelectedIndex].Vega ? "vega" : "hús";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var asz = new Dictionary<int, int>();
                foreach (var v in vendegek)
                {
                    if (!asz.ContainsKey(v.Asztal))
                    {
                        asz.Add(v.Asztal, 1);
                    }
                    else {asz[v.Asztal]++;}
                }

            //Dictionary érték kiiratás
            var sw2 = new StreamWriter("Dictionary.txt");
            foreach (KeyValuePair<int, int> kvp in asz)
            {
                sw2.WriteLine(kvp.Key + "-->" + kvp.Value);
            }

            // ??
            /*
            var s = "";
            foreach (var item in asz.Keys)
            {
                s += item + " ";
            }
            */

            //Dictionary (string, string)
            /*
            var dic = new Dictionary<string, string[]>();
            string[] st = { "cat", "pussy", "kitty" };

            dic.Add("cica", st);

            MessageBox.Show(dic["cica"][0]);
            */

            sw2.Close();
            //

            if (cb_nev.Items.Contains(tb_nev.Text))
            {
                MessageBox.Show("Ez a vendég már meg lett hívva!");
            }
            else if (asz[int.Parse(tb_asztal.Text)] >= 5)
            {
                MessageBox.Show("Ez az asztal már tele van!");
            }
            else
            {
                var sw = new StreamWriter("vendegek.txt", true, Encoding.UTF8);
                sw.WriteLine(
                    $"{tb_nev.Text};" +
                    $"{(rd_ferfi.Checked ? "m" : "f")};" +
                    $"{tb_asztal.Text };" +
                    $"{(cb_vega.Checked ? "v" : "m")}" );
                sw.Close();
                Application.Restart();
            }
            


        }
    }
}
