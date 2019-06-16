using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionDay.Classes
{
    public static class Election
    {
        public static string VotiTotali(List<SeggioElettorale> seggi)
        {
            int totalVotes = 0, bianchi = 0, nulle = 0;
            foreach(SeggioElettorale s in seggi)
            {
                totalVotes += s.VotiTotali();
                bianchi += s.SchedeBianche;
                nulle += s.SchedeNulle;
            }
            return "I voti totali per queste elezioni sono: " + totalVotes + "\r\n"
                + "I voti nulli sono: " + nulle + "\r\n"
                + "Le schede bianche sono: " + bianchi + "\r\n";
        }

        public static string VotiPartiti(List<SeggioElettorale> seggi)
        {
            string votiPartiti = "";
            Dictionary<string, int> save = new Dictionary<string, int>();
            for (int i = 0; i < seggi[0].Partiti.Count; i++)
            {
                int partito = 0;
                foreach (SeggioElettorale s in seggi)
                {
                    partito += s.Partiti[i].Voto;
                }
                votiPartiti += seggi[0].Partiti[i].Nome + ": " + partito + "\r\n";
                save.Add(seggi[0].Partiti[i].Nome, partito);
            }
            string winners = "";
            foreach (KeyValuePair<string, int> s in save)
            {
                if (s.Value == save.Max(x => x.Value))
                {
                    winners += s.Key + " " + s.Value + "\r\n";
                }
            }
            votiPartiti += "\r\nA vincere queste elezioni...\r\n" + winners + "\r\n";
            return "\r\nI voti dei partiti sono:\r\n" + votiPartiti + "\r\n"; 
        }
    }
}
