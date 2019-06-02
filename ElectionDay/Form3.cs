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
    public partial class Form3 : Form
    {
        private List<Partito> _partiti=null;
        private List<SeggioElettorale> _seggi = null;

        public Form3(List<Partito> partiti, List<SeggioElettorale> seggi)
        {
            InitializeComponent();
            _partiti = partiti;
            _seggi = seggi;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.AppendText(Election.VotiTotali(_seggi));
            textBox1.AppendText(Election.VotiPartiti(_seggi, _partiti));
        }
    }
}
