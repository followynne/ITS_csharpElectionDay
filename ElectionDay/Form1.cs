using ElectionDay.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionDay
{
    public partial class Form1 : Form
    {
        public List<SeggioElettorale> Seggi { get; set; }
        public List<SeggioElettorale> SeggiRegionali { get; set; }

        public Form1()
        {
            InitializeComponent();
            Seggi = new List<SeggioElettorale> {
                (new SeggioElettorale("201", "Torino", "Piemonte")),
                (new SeggioElettorale("202", "Torino", "Piemonte")),
                (new SeggioElettorale("210", "Milano", "Lombardia")),
                (new SeggioElettorale("211", "Pisa", "Toscana"))
            };
            SeggiRegionali = new List<SeggioElettorale> {
                (new SeggioElettorale("201", "Torino", "Piemonte")),
                (new SeggioElettorale("202", "Torino", "Piemonte")),
                (new SeggioElettorale("210", "Milano", "Lombardia")),
                (new SeggioElettorale("211", "Pisa", "Toscana"))
            };
        }

        #region consegna
        /* Scrivere app per raccolta dati di turno elettorale.
         * Nel caso in cui ci sia elezione regionale, aggregare i dati per candidato presidente di regione.
         * 
         * Nel caso di votazione nazionale, il comportamento è il base (assegnazione al partito di riferimento).
         *
         * Creare una lista contenente la lista dei partiti (selezione obbligatoria)
         * Prevedere anche schede nulle e bianche.
         * Le schede nulle e bianche non sono conteggiate come voti.
         * 
         * Inserire voti totali per il partito
         * Scrivere in una textbox il numero del seggio elettorale (Numero)
         * 
         * I voti calcolati in base al tipo di votazione, andranno scritti in file txt
         * Nel caso di votazione regionale, visualizzare i voti complessivi per il candidato presidente, oltre che per singoli partiti.
         */
        #endregion

        private void btnNazionali_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(Seggi);
            f.Show();
        }

        private void btnRegionali_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(SeggiRegionali, btnRegionali);
            f.Show();
        }

        private void btnCalcNaz_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(Seggi, btnCalcNaz);
            f.ShowDialog();
        } 

        private void btnCalcReg_Click(object sender, EventArgs e)
        {

            Form3 f = new Form3(SeggiRegionali, btnCalcReg, lblRegPV);
            f.ShowDialog();
        }
    }
}
