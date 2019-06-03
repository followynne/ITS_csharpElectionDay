using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectionDay.Classes;

namespace ElectionDay.Classes
{
    public class Partito
    {
        public Partito(string nome)
        {
            _nome = nome;
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _voto;

        public int Voto
        {
            get { return _voto; }
            set { _voto = value; }
        }

        public override string ToString()
        {
            return _nome;
        }

    }
}
