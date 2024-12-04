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
    public partial class FormaZadatak3 : Form
    {
        private BindingList<Profesor> profesori = new BindingList<Profesor>();
        private BindingList<Predmet> predmeti = new BindingList<Predmet>();
        private BindingList<PP> pp = new BindingList<PP>();
        private BindingList<PP> izabraniPP = new BindingList<PP>();
        private Broker broker = new();

        public FormaZadatak3()
        {
            broker.VratiSveProfesore(profesori);
            broker.VratiSvePredmete(predmeti);
            broker.VratiSvePP(pp, predmeti.ToList(), profesori.ToList());

            InitializeComponent();

            listBoxProfesori.DataSource = profesori;
            listBoxProfesori.DisplayMember = "ImePrezime";
            listBoxProfesori.SelectedIndex = -1;

            dataGridViewPP.DataSource = izabraniPP;
            dataGridViewPP.Columns["profesor"].Visible = false;
            dataGridViewPP.Columns["predmet"].Visible = false;
            dataGridViewPP.Columns[2].HeaderText = "Profesor";
            dataGridViewPP.Columns[3].HeaderText = "Predmet";

            panel1.Enabled = false;
            
        }

        public void VidiAngazovanja(object sender, EventArgs e)
        {
            izabraniPP.Clear();

            foreach (var prof in listBoxProfesori.SelectedItems)
            {
                Profesor izabraniProfesor = (Profesor)prof;
                var njegoviPP = pp.ToList().FindAll(x => x.Profesor.Id == izabraniProfesor.Id);
                foreach (var p in njegoviPP)
                {
                    izabraniPP.Add(p);
                }
            }
        }
    }
}
