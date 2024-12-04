using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FormaZadatak1 : Form
    {
        BindingList<PoreskaStopa> poreskeStope = new BindingList<PoreskaStopa>();
        BindingList<Proizvodjac> proizvodjaci = new BindingList<Proizvodjac>();
        BindingList<Proizvod> proizvodi = new BindingList<Proizvod>();

        public FormaZadatak1()
        {
            PoreskaStopa ps1 = new PoreskaStopa { Sifra = 1, SkraceniNaziv = "PDV", Iznos = 0.2 };
            PoreskaStopa ps2 = new PoreskaStopa { Sifra = 2, SkraceniNaziv = "Izvoz", Iznos = 0.3 };
            poreskeStope.Add(ps1);
            poreskeStope.Add(ps2);

            Proizvodjac pr1 = new Proizvodjac { Sifra = 1, Naziv = "ABC Komerc" };
            Proizvodjac pr2 = new Proizvodjac { Sifra = 2, Naziv = "Voda voda" };
            Proizvodjac pr3 = new Proizvodjac { Sifra = 3, Naziv = "Jaffa" };
            proizvodjaci.Add(pr1);
            proizvodjaci.Add(pr2);
            proizvodjaci.Add(pr3);

            Proizvod p1 = new Proizvod { Sifra = 100, Naziv = "Krem sir", Cena = 250, PoreskaStopa = ps1, Proizvodjac = pr1 };
            Proizvod p2 = new Proizvod { Sifra = 200, Naziv = "Mala voda", Cena = 50, PoreskaStopa = ps1, Proizvodjac = pr2 };
            Proizvod p3 = new Proizvod { Sifra = 300, Naziv = "Jafa keks", Cena = 299, PoreskaStopa = ps1, Proizvodjac = pr3 };
            proizvodi.Add(p1);
            proizvodi.Add(p2);
            proizvodi.Add(p3);

            InitializeComponent();

            labelNaziv.Text = "";
            labelCena.Text = "";
            labelProizvodjac.Text = "";
            labelPoreskaStopa.Text = "";

            comboBoxProizvodi.DataSource = proizvodi;
            comboBoxProizvodi.DisplayMember = "Naziv";
            comboBoxProizvodi.TextChanged += ComboBoxPromenjenaSelekcija;

            comboBoxProizvodjaci.DataSource = proizvodjaci;
            comboBoxProizvodjaci.DisplayMember = "Naziv";

            comboBoxPoreskaStopa.DataSource = poreskeStope;
            comboBoxPoreskaStopa.DisplayMember = "SkraceniNaziv";
            

        }

        public void ComboBoxPromenjenaSelekcija(object sender, EventArgs e)
        {
            if (comboBoxProizvodi.SelectedItem == null) panel1.Enabled = false;
            else
            {
                panel1.Enabled = true;
                prikaziDetaljeProizvoda(comboBoxProizvodi.SelectedItem as Proizvod);
            }
        }

        private void buttonIzmeniProizvod_Click(object sender, EventArgs e)
        {
            Proizvod izabraniProizvod = (Proizvod)comboBoxProizvodi.SelectedItem;
            string naziv = textBoxNaziv.Text.Trim();
            double cena = (double)numericUpDownCena.Value;
            Proizvodjac proizvodjac = comboBoxProizvodjaci.SelectedItem as Proizvodjac;
            PoreskaStopa poreskaStopa = comboBoxPoreskaStopa.SelectedItem as PoreskaStopa;

            if (naziv.Length == 0)
            {
                FormaGlavna.PrikaziGreskuZaLosUnos("Polje 'Naziv'");
                return;
            }
            if (proizvodjac is null)
            {
                FormaGlavna.PrikaziGreskuZaLosUnos("Polje 'Proizvodjac'");
                return;
            }
            if (poreskaStopa is null)
            {
                FormaGlavna.PrikaziGreskuZaLosUnos("Polje 'Poreska stopa'");
                return;
            }

            Proizvod izmenjeniProizvod = new Proizvod
            {
                Sifra = izabraniProizvod.Sifra,
                Naziv = naziv,
                Cena = cena,
                Proizvodjac = proizvodjac,
                PoreskaStopa = poreskaStopa,
            };

            proizvodi.Remove(izabraniProizvod);
            proizvodi.Add(izmenjeniProizvod);
        }

        private void prikaziDetaljeProizvoda(Proizvod p)
        {
            labelNaziv.Text = p.Naziv;
            labelCena.Text = p.Cena.ToString();
            labelProizvodjac.Text = p.Proizvodjac.Naziv;
            labelPoreskaStopa.Text = p.PoreskaStopa.SkraceniNaziv;
        }
    }
}
