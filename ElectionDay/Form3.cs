using ElectionDay.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionDay
{
    public partial class Form3 : Form
    {
        private Button _button = null;
        private List<SeggioElettorale> _seggi = null;
        private List<Candidato> candidati = null;

        public Form3(List<SeggioElettorale> seggi, Button b)
        {
            InitializeComponent();
            _seggi = seggi;
            _button = b;
            candidati = new List<Candidato> {
                new Candidato ("Salvini", new List<Partito> { new Partito("PD"), new Partito("Sinistra Radicale") }),
                new Candidato ("Renzi", new List<Partito> { new Partito("Lega Nord"), new Partito("Fratelli d'Italia"), new Partito("Fratelli d'Italia")}),
                new Candidato ("Marcone", new List<Partito> { new Partito("M5S"), new Partito("Forza Italia")})};
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.AppendText(Election.VotiTotali(_seggi));
            textBox1.AppendText(Election.VotiPartiti(_seggi));
            if (_button.Name.Equals("btnCalcReg"))
            {
               string resCandidati = "";
               foreach (Candidato c in candidati)
               {
                  resCandidati +=  c.VotiCandidato(_seggi);
               }
               textBox1.AppendText(resCandidati);
            }

            string path = @"../../File/x" + DateTime.Now.ToString("yyyyMMdd hhmmss") + ".txt";
            var f = File.CreateText(path);
            string riepilogo = "";
            foreach (SeggioElettorale s in _seggi)
            {
                riepilogo += s.Riepilogo();
            };
            f.Write(riepilogo);
            f.Close();
        }
    }
}
