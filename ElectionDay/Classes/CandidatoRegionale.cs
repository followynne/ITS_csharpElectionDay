using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionDay.Classes
{
    class CandidatoRegionale : AbstractVotabile
    {
        public CandidatoRegionale(string nome, ArrayList partiti) : base(nome)
        {
            _partitiAffiliati = partiti;
            votiPresi(_partitiAffiliati);
        }

        private ArrayList _partitiAffiliati;

        public ArrayList PartitiAffiliati
        {
            get { return _partitiAffiliati; }
            set { _partitiAffiliati = value; }
        }

        public override int votiPresi(ArrayList al)
        {
            throw new NotImplementedException();
        }
    }
}
