using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KolekcijeVjezba
{
    public partial class Form1 : Form
    {
        List<Osoba> osobe = new List<Osoba>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                Osoba osoba = new Osoba(txtIme.Text, txtPrezime.Text, Convert.ToInt32(txtGodina.Text), cmbRod.Text, "");

                osobe.Add(osoba);

                txtIme.Clear();
                txtPrezime.Clear();
                txtGodina.Clear();

                MessageBox.Show("Uspješan unos!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception greska)
            {
                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            rtbIspis.AppendText("Ime" + "\tPrezime" + "\tGodina" + "\tSpol" + "\tDodatak" + "\r\n");
            foreach (Osoba osoba in osobe)
            {
                rtbIspis.AppendText(osoba.ToString() + "\r\n");
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach (Osoba osoba in osobe)
            {
                if (osoba.Spol == "M")
                {
                    osoba.Dodatak = "Ima brkove";
                }
                else
                {
                    osoba.Dodatak = "Nema brkove";
                }

            }
            foreach (Osoba osoba in osobe)
            {
                rtbIspis.AppendText(osoba.ToString() + "\r\n");
            }
        }
    }
}
