﻿using System;
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

        public Form2()
        { 
        }

        public Form2(List<SeggioElettorale> seggi)
        {
            InitializeComponent();
            this.seggi = seggi;
            foreach (SeggioElettorale s in seggi)
            {
                cbxSeggio.Items.Add(s.NumSeggio);
            }
            foreach (Partito p in seggi[0].Partiti)
                {
                    cbxPartiti.Items.Add(p.Nome);
                }
        }

        private void btnSaveVote_Click(object sender, EventArgs e)
        {
            try
            {
                int s = seggi.FindIndex(x => x.NumSeggio.Equals(cbxSeggio.Text));
                int p = seggi[s].Partiti.FindIndex(x => x.Nome.Equals(cbxPartiti.Text));

                if (!(int.TryParse(txtVoto.Text, out int res)))
                {
                    seggi[s].Partiti[p].Voto = 0;
                }
                else
                {
                    seggi[s].Partiti[p].Voto = res;
                };
                Console.WriteLine(seggi.ToString());
                textBox1.Text = seggi[s].ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("LOL!");
            }
        }
    }
}
