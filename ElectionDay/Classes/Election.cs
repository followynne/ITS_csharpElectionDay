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

        static List<Candidato> candidati = new List<Candidato> {
                new Candidato ("Salvini", new List<Partito> { new Partito("PD"), new Partito("Sinistra Radicale") }),
                new Candidato ("Renzi", new List<Partito> { new Partito("Lega Nord"), new Partito("Fratelli d'Italia"), new Partito("Fratelli d'Italia")}),
                new Candidato ("Marcone", new List<Partito> { new Partito("M5S"), new Partito("Forza Italia")})};
        /*
        static Candidato Candidato1 = new Candidato ("Salvini", new List<Partito> { new Partito("PD"),
            new Partito("Sinistra Radicale") });
        private static Candidato Candidato2 = new Candidato ("Renzi", new List<Partito> { new Partito("Lega Nord"),
            new Partito("Fratelli d'Italia"),
            new Partito("Fratelli d'Italia")});
        private static Candidato Candidato3 = new Candidato ("Marcone" , new List<Partito> { new Partito("M5S"),
            new Partito("Forza Italia")});
        */
        public static string VotiTotali(List<SeggioElettorale> seggi)
        {
            int totalVotes = 0;
            foreach(SeggioElettorale s in seggi)
            {
                totalVotes += s.VotiTotali();
            }
            return "I voti totali per queste elezioni sono: " + totalVotes + "\n";
        }

        public static string VotiPartiti(List<SeggioElettorale> seggi)
        {
            string votiPartiti = "";
            for (int i = 0; i<seggi[0].Partiti.Count; i++)
            {
                int partito = 0;
                foreach (SeggioElettorale s in seggi)
                {
                    partito += s.Partiti[i].Voto;
                }
                votiPartiti += seggi[0].Partiti[i].Nome + ": " + partito + "\n";
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

        public static string VotiCandidati(List<SeggioElettorale> seggi)
        {
            foreach (SeggioElettorale s in seggi)
            {
                foreach (Partito p in s.Partiti)
                {
                    if (candidati[0].PartitiAssociati.Exists(x => x.Nome.Equals(p.Nome)))
                    {
                        candidati[0].VotiTot += p.Voto;
                    }
                    else if (candidati[1].PartitiAssociati.Exists(x => x.Nome.Equals(p.Nome)))
                    {
                        candidati[1].VotiTot += p.Voto;
                    }
                    else if (candidati[2].PartitiAssociati.Exists(x => x.Nome.Equals(p.Nome)))
                    {
                        candidati[2].VotiTot += p.Voto;
                    }
                }
            }

            return "Per ogni candidato i voti sono: " 
                + candidati[0] + " = " + candidati[0].VotiTot + "\n"
                + candidati[1] + " " + candidati[1].VotiTot 
                + "\n" + candidati[2] + " " + candidati[2].VotiTot + "\n";
        }

    }
}
