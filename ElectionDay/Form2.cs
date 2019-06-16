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
        private List<SeggioElettorale> _seggi;
        private Button _button;

        public Form2(List<SeggioElettorale> seggi)
        {
            InitializeComponent();
            this._seggi = seggi;
            int i = 0;
            foreach (SeggioElettorale s in seggi)
            {
                cbxSeggio.Items.Add(s);
                cbxSeggio.DisplayMember= s.NumSeggio;
            }
            foreach (Partito p in seggi[0].Partiti)
            {
                cbxPartiti.Items.Add(p);
                i++;
            }
        }

        public Form2(List<SeggioElettorale> seggi, Button b)
        {
            InitializeComponent();
            this._seggi = seggi;
            _button = b;
            int i = 0;
            foreach (SeggioElettorale s in seggi)
            {
                cbxSeggio.Items.Add(s);
                cbxSeggio.DisplayMember = s.NumSeggio;
            }
            foreach (Partito p in seggi[0].Partiti)
            {
                cbxPartiti.Items.Add(p);
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
                int s = _seggi.FindIndex(x => x.NumSeggio.Equals(((SeggioElettorale)cbxSeggio.SelectedItem).NumSeggio));
                int p = _seggi[s].Partiti.FindIndex(x => x.Nome.Equals(((Partito)cbxPartiti.SelectedItem).Nome));

                if (!(int.TryParse(txtVoto.Text, out int res)))
                {
                    _seggi[s].Partiti[p].Voto = 0;
                }
                else
                {
                    _seggi[s].Partiti[p].Voto = res;
                };
                textBox1.Text = _seggi[s].Riepilogo();
            }
            catch (Exception)
            { 
                MessageBox.Show("Hai messo dei dati non validi, controlla!");
            }
        }

        private void btnSchede_Click(object sender, EventArgs e)
        {
            try
            {
                int s = _seggi.FindIndex(x => x.NumSeggio.Equals(((SeggioElettorale)cbxSeggio.SelectedItem).NumSeggio));
                int p = _seggi[s].Partiti.FindIndex(x => x.Nome.Equals(((Partito)cbxPartiti.SelectedItem).Nome));

                if (!(int.TryParse(txtBianche.Text, out int res)))
                {
                    _seggi[s].SchedeBianche = 0;
                }
                else
                {
                    _seggi[s].SchedeBianche= res;
                };
                if (!(int.TryParse(txtNulle.Text, out int res2)))
                {
                    _seggi[s].SchedeNulle = 0;
                }
                else
                {
                    _seggi[s].SchedeNulle = res2;
                };
                textBox1.Text = _seggi[s].Riepilogo();
            }
            catch (Exception)
            {
                MessageBox.Show("Hai messo dei dati non validi, controlla!");
            }
        }
    }
}
