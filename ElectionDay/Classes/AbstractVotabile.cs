using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionDay.Classes
{
    public abstract class AbstractVotabile
    {
        public AbstractVotabile(string nome)
        {
            _nome = nome;
        }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public abstract int votiPresi(ArrayList al);

    }
}
