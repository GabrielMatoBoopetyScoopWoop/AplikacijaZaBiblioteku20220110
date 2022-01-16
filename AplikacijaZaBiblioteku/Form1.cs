using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplikacijaZaBiblioteku
{
    public partial class Form1 : Form
    {
        // XElement Biblioteka = new XElement();
        public Form1()
        {
            InitializeComponent();
        }

        private void UpisKorisnikaButton_Click(object sender, EventArgs e)
        {
            UpisKorisnika Korisnik = new UpisKorisnika();
            Korisnik.ShowDialog();
        }

        private void PVButton_Click(object sender, EventArgs e)
        {
            PosudbaVracanje PV = new PosudbaVracanje();
            PV.ShowDialog();
        }

        private void UpisKnjigeButton_Click(object sender, EventArgs e)
        {
            UpisKnjige Knjiga = new UpisKnjige();
            Knjiga.ShowDialog();
        }

        private void DBBrowserButun_Click(object sender, EventArgs e)
        {
            Pretraga pretraga = new Pretraga();
            pretraga.ShowDialog();
        }

        private void ZatvoriButun_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
