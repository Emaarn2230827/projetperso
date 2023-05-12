using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{
    enum Statut
    {
        stagiaire,
        permanent
    }
    internal class Enseignant
    {
        public string CodeEns { get; set; } 
        public string NomEns { get; set; }
        public string NomProg { get; set; }
        public Statut StatutEns { get; set; }   

        public Enseignant(string codeEns, string nomEns, string nomProg, Statut statutEns)
        {
            CodeEns = codeEns;
            NomEns = nomEns;
            NomProg = nomProg;
            StatutEns = statutEns;
        }

        public override string ToString()
        {
            string info = $"Code enseignant: {CodeEns} \nNom: {NomEns} \nProgramme: {NomProg} \nStatut: {StatutEns} \n";
            return info; 
        }
    }
}
