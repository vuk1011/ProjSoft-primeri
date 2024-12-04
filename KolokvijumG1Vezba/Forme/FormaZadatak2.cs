using BrokerBaze;
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
    public partial class FormaZadatak2 : Form
    {
        BindingList<Profesor> profesori = new BindingList<Profesor>();
        Broker broker = new();
        
        public FormaZadatak2()
        {
            broker.VratiSveProfesore(profesori);

            InitializeComponent();

            panel1.Enabled = false;

            dataGridViewProfesori.DataSource = profesori;
            dataGridViewProfesori.Columns["id"].Visible = false;
            dataGridViewProfesori.SelectionChanged += PromenjenaSelekcija;

            buttonSacuvaj.Click += IzmeniProfesora;
        }

        private void OsveziProfesore()
        {
            profesori.Clear();
            broker.VratiSveProfesore(profesori);
        }

        private void PromenjenaSelekcija(object sender, EventArgs e)
        {
            if (dataGridViewProfesori.CurrentRow == null)
            {
                panel1.Enabled = false;
                return;
            }
            Profesor p = (Profesor)dataGridViewProfesori.CurrentRow.DataBoundItem;
            panel1.Enabled = p.Status.Equals("aktivan");
        }

        private void IzmeniProfesora(object sender, EventArgs e)
        {
            string ime = textBoxIme.Text.Trim();
            if (ime.Equals(""))
            {
                FormaGlavna.PrikaziGreskuZaLosUnos("Polje 'Ime'");
                return;
            }

            string prezime = textBoxPrezime.Text.Trim();
            if (prezime.Equals(""))
            {
                FormaGlavna.PrikaziGreskuZaLosUnos("Polje 'Prezime'");
                return;
            }

            if (comboBoxZvanje.SelectedItem == null)
            {
                FormaGlavna.PrikaziGreskuZaLosUnos("Polje 'Zvanje'");
                return;
            }
            string zvanje = comboBoxZvanje.SelectedItem.ToString();
            long id = ((Profesor)dataGridViewProfesori.CurrentRow.DataBoundItem).Id;

            broker.UpdateProfesor(id, ime, prezime, zvanje);
            OsveziProfesore();
        }
    }
}
