using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionDay.Classes
{
    public class Election
    {
        public static string VotiTotali(List<SeggioElettorale> seggi)
        {
            int totalVotes = 0;
            foreach(SeggioElettorale s in seggi)
            {
                totalVotes += s.VotiTotali();
            }
            return "I voti totali per queste elezioni sono: " + totalVotes + "\n";
        }

        public static string VotiPartiti(List<SeggioElettorale> seggi, List<Partito> partiti)
        {
            string votiPartiti = "";
            for (int i = 0; i<partiti.Count; i++)
            {
                int partito = 0;
                foreach (SeggioElettorale s in seggi)
                {
                    partito += s.Partiti[i].Voto;
                }
                votiPartiti += partiti[i].Nome + ": " + partito + "\n";
            }
            return "I voti dei partiti sono:" + votiPartiti + "\n";
        }

        public static string ToStringPartiti(List<SeggioElettorale> seggi)
        {
            string risultati = "";

            foreach (SeggioElettorale s in seggi)
            {
                risultati += "Per il seggio" + s.NumSeggio + ", città " + s.Città + ", i risultati sono:\n";
                foreach (Partito p in s.Partiti)
                {
                    risultati += p.Nome + " = " + p.Voto + "\n";
                }
                risultati += "Schede Nulle = " + s.SchedeNulle + "\n\n";
            }
            return risultati;
        }
    }
}
