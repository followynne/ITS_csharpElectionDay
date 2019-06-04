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
        private Label _label = null;
        private List<SeggioElettorale> _seggi = null;

        public Form3(List<SeggioElettorale> seggi, Button b)
        {
            InitializeComponent();
            _seggi = seggi;
            _button = b;
        }

        public Form3(List<SeggioElettorale> seggi, Button b, Label l)
        {
            InitializeComponent();
            _seggi = seggi;
            _button = b;
            _label = l;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (_button.Name.Equals("btnCalcNaz")) {
                textBox1.AppendText(Election.VotiTotali(_seggi));
                textBox1.AppendText(Election.VotiPartiti(_seggi));
                // stampa su file con ToStringPartiti
            } else if (_button.Name.Equals("btnCalcReg"))
            {
                textBox1.AppendText(Election.VotiTotali(_seggi));
                textBox1.AppendText(Election.VotiPartiti(_seggi));
                textBox1.AppendText(Election.VotiCandidati(_seggi));
            }

            string path = @"../../File/x" + DateTime.Now.ToString("yyyyMMdd hhmm") + ".txt";
            var f = File.CreateText(path);
            f.Write(Election.ToStringPartiti(_seggi));
            f.Close();
        }
    }
}
