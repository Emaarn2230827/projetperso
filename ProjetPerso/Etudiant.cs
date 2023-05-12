using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPerso
{
    enum Niveau
    {
        annee1,
        annee2,
        annee3
    }
    internal class Etudiant
    {
        public string NumDa { get; set; }
        public string NomPrenom { get; set; }   
        public string NomProg { get; set; }  
        public Niveau Level { get; set; }  
        public Etudiant(string numDa, string nomPrenom, string nomP, Niveau level)
        {
            NumDa = numDa;
            NomPrenom = nomPrenom;
            NomProg = nomP;
            Level = level;  
        }

        public override string ToString()
        {
            string info = $"Numero de DA: {NumDa} \nPrenom/Nom: {NomPrenom} \nProgramme:{NomProg} \nNiveau:{Level} \n";
            return info;
        }
    }
}
