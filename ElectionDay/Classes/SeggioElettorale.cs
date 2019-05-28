using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionDay.Classes
{
    class SeggioElettorale
    {
        private string _numSeggio;

        public string NumSeggio
        {
            get { return _numSeggio; }
            set { _numSeggio = value; }
        }

        private string _città;

        public string Città
        {
            get { return _città; }
            set { _città = value; }
        }

        private int _schedeNulle;

        public int SchedeNulle
        {
            get { return _schedeNulle; }
            set { _schedeNulle = value; }
        }

        private Dictionary<string, int> _partitieVoti;

        public Dictionary<string, int> PartitieVoti
        {
            get { return _partitieVoti; }
            set { _partitieVoti = value; }
        }

    }
}
