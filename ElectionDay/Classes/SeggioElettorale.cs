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
        public SeggioElettorale(string seggio, string città, string regione)
        {
            _numSeggio = seggio;
            _città = città;
            _regione = regione;
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

        private string _regione;

        public string Regione
        {
            get { return _regione; }
            set { _regione = value; }
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
            int tot = 0;
            foreach (Partito p in _partiti)
            {
                tot += p.Voto;
            }
            return (tot += _schedeBianche + _schedeNulle);
        }

        public string Riepilogo()
        {
            string results = "I voti del seguente seggio " + _numSeggio + ", città " + _città + ", regione " + _regione + " sono:\n";
            foreach(Partito p in _partiti)
            {
                results += p.Nome + " " + p.Voto + "\n";
            }
            results += "Schede Bianche " + _schedeBianche + "\n";
            results += "Schede Nulle " + _schedeNulle + "\n";
            return results;
        }

        public override string ToString()
        {
            return _numSeggio;
        }
    }
}
