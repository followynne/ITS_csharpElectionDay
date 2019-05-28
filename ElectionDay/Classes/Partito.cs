using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectionDay.Classes;

namespace ElectionDay.Classes
{
    public class Partito : AbstractVotabile
    {
        public Partito(string nome) : base(nome)
        {
        }

        public override int votiPresi(ArrayList al)
        {
            int votiTot = 0;
            foreach(SeggioElettorale s in al)
            {
                votiTot += s.PartitieVoti[Nome];
            }

            return votiTot;
        }
    }
}
