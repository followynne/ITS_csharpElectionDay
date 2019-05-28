using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionDay.Classes
{
    class Partito : AbstractVotabile
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public override int votiPresi()
        {
            throw new NotImplementedException();
        }
    }
}
