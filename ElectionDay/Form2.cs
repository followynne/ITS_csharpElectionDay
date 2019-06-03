using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectionDay.Classes;

namespace ElectionDay
{
    public partial class Form2 : Form
    {
        private List<SeggioElettorale> seggi;
        private Button _button;
        private Boolean flag = false;

        public Form2(List<SeggioElettorale> seggi)
        {
            InitializeComponent();
            this.seggi = seggi;
            int i = 0;
            foreach (SeggioElettorale s in seggi)
            {
                cbxSeggio.Items.Add(s);
                cbxSeggio.DisplayMember= s.NumSeggio;
                //cbxSeggio.Text = s.NumSeggio;
            }
            foreach (Partito p in seggi[0].Partiti)
            {
                cbxPartiti.Items.Add(p);
                //cbxPartiti.Items[i-seggi.Count] = p.Nome;
                i++;
            }
        }

        public Form2(List<SeggioElettorale> seggi, Button b)
        {
            InitializeComponent();
            this.seggi = seggi;
            _button = b;
            flag= true;
            int i = 0;
            foreach (SeggioElettorale s in seggi)
            {
                cbxSeggio.Items.Add(s);
                cbxSeggio.DisplayMember = s.NumSeggio;
                //cbxSeggio.Text = s.NumSeggio;
            }
            foreach (Partito p in seggi[0].Partiti)
            {
                cbxPartiti.Items.Add(p);
                //cbxPartiti.Items[i-seggi.Count] = p.Nome;
                i++;
            }
        }

        private void cbxSeggio_DropDownClosed(object sender, EventArgs e)
        {
            try
            {
                SeggioElettorale s = cbxSeggio.SelectedItem as SeggioElettorale;
                txtCity.Text = s.Città;
                txtPV.Text = s.Regione;
                txtBianche.Text = ""+s.SchedeBianche;
                txtNulle.Text = ""+s.SchedeNulle;
                textBox1.Text = s.Riepilogo();
                if (flag)
                {
                    //lblCandidato.Text = Election.
                    //MessageBox.Show("Lol");
                }
            }
            catch (Exception)
            {
                cbxSeggio.SelectedIndex = 0;
            }
        }

        private void btnSaveVote_Click(object sender, EventArgs e)
        {
            try
            {
                int s = seggi.FindIndex(x => x.NumSeggio.Equals(((SeggioElettorale)cbxSeggio.SelectedItem).NumSeggio));
                int p = seggi[s].Partiti.FindIndex(x => x.Nome.Equals(((Partito)cbxPartiti.SelectedItem).Nome));

                if (!(int.TryParse(txtVoto.Text, out int res)))
                {
                    seggi[s].Partiti[p].Voto = 0;
                }
                else
                {
                    seggi[s].Partiti[p].Voto = res;
                };
                textBox1.Text = seggi[s].Riepilogo();
            }
            catch (Exception)
            { 
                MessageBox.Show("LOL!");
            }
        }

        private void btnSchede_Click(object sender, EventArgs e)
        {
            try
            {
                int s = seggi.FindIndex(x => x.NumSeggio.Equals(((SeggioElettorale)cbxSeggio.SelectedItem).NumSeggio));
                int p = seggi[s].Partiti.FindIndex(x => x.Nome.Equals(((Partito)cbxPartiti.SelectedItem).Nome));

                if (!(int.TryParse(txtBianche.Text, out int res)))
                {
                    seggi[s].SchedeBianche = 0;
                }
                else
                {
                    seggi[s].SchedeBianche= res;
                };
                if (!(int.TryParse(txtNulle.Text, out int res2)))
                {
                    seggi[s].SchedeNulle = 0;
                }
                else
                {
                    seggi[s].SchedeNulle = res2;
                };
                textBox1.Text = seggi[s].Riepilogo();
            }
            catch (Exception)
            {
                MessageBox.Show("LOL!");
            }
        }
    }
}
