using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectionDay.Classes
{
    public static class Election
    {
        static List<Candidato> candidati = new List<Candidato> {
                new Candidato ("Salvini", new List<Partito> { new Partito("PD"), new Partito("Sinistra Radicale") }),
                new Candidato ("Renzi", new List<Partito> { new Partito("Lega Nord"), new Partito("Fratelli d'Italia"), new Partito("Fratelli d'Italia")}),
                new Candidato ("Marcone", new List<Partito> { new Partito("M5S"), new Partito("Forza Italia")})};

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
            for (int i = 0; i < seggi[0].Partiti.Count; i++)
            {
                int partito = 0;
                foreach (SeggioElettorale s in seggi)
                {
                    partito += s.Partiti[i].Voto;
                }
                votiPartiti += seggi[0].Partiti[i].Nome + ": " + partito + " \r\n";
            }
            return "\r\nI voti dei partiti sono:" + votiPartiti + "\r\n";
        }

        //public static string ToStringPartiti(List<SeggioElettorale> seggi)
        //{
        //    string risultati = "";

        //    foreach (SeggioElettorale s in seggi)
        //    {
        //        risultati += "Per il seggio" + s.NumSeggio + ", città " + s.Città + ", i risultati sono:\n";
        //        foreach (Partito p in s.Partiti)
        //        {
        //            risultati += p.Nome + " = " + p.Voto + "\n";
        //        }
        //        risultati += "Schede Nulle = " + s.SchedeNulle + "\n\n";
        //    }
        //    return risultati;
        //}

        public static string VotiCandidati(List<SeggioElettorale> seggi)
        {
            foreach (SeggioElettorale s in seggi)
            {
                foreach (Partito p in s.Partiti)
                {
                    for (int i = 0; i < candidati.Count; i++)
                    {
                        if (candidati[i].PartitiAssociati.Exists(x => x.Nome.Equals(p.Nome)))
                        {
                            candidati[i].VotiTot += p.Voto;
                        }
                    }
                }
            }
            string stampa = "Per ogni candidato i voti sono:\r\n";
            for (int i = 0; i<candidati.Count; i++)
            {
                stampa += candidati[i].Nome + " = " + candidati[0].VotiTot + "\r\n";
            }
            return stampa + "\r\n";
        }

    }
}
