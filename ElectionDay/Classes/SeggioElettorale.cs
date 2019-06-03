using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ElectionDay.Classes
{
    public class SeggioElettorale
    {
        public SeggioElettorale(string seggio, string città)
        {
            _numSeggio = seggio;
            _città = città;
            _schedeNulle = 0;
            _schedeBianche = 0;
            _partiti = new List<Partito> {
                new Partito("PD"),
                new Partito("Lega Nord"),
                new Partito("M5S"),
                new Partito("Forza Italia"),
                new Partito("Fratelli d'Italia"),
                new Partito("Sinistra Radicale")
            }; 
        }

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
        private int _schedeBianche;

        public int SchedeBianche
        {
            get { return _schedeBianche; }
            set { _schedeBianche = value; }
        } 

        private List<Partito> _partiti;

        public List<Partito> Partiti
        {
            get { return _partiti; }
            
        }

        public int VotiTotali()
        {
            return 0;
        }

        public override string ToString()
        {
            string results = "I voti del seguente seggio " + _numSeggio + " sono:\n";
            foreach(Partito p in _partiti)
            {
                results += p.Nome + " " + p.Voto + "\n";
            }
            results += "Schede Bianche " + _schedeBianche;
            results += "Schede Nulle " + _schedeNulle;
            return results;
        }

    }
}
