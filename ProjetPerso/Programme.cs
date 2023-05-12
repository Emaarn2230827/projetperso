using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using Figgle;
using System.Drawing;

namespace ProjetPerso
{
    internal class Programme
    {
        public string CodeProgr { get; set; }   
        public string NomProgr { get; set; }   
        public List<Etudiant> Etudiants { get; set; }   
        public List<Enseignant> Enseignants { get; set; }   

        public Programme(string codeProgr, string nomProgr, List<Etudiant> etudiants, List<Enseignant> enseignants)
        {
            CodeProgr = codeProgr;
            NomProgr = nomProgr;
            Etudiants = etudiants;
            Enseignants = enseignants;
        }
        public Programme(string codeProgr, string nomProgr)
        {
            CodeProgr = codeProgr;
            NomProgr = nomProgr;
            Etudiants = new List<Etudiant>();
            Enseignants = new List<Enseignant>();
        }
        public override string ToString()
        {
            string info = $"Code: {CodeProgr} \nNom: {NomProgr} \nEtudiant(s) inscrit(s): \n";
            foreach (Etudiant etu in Etudiants)
            {
                info += etu.ToString();
            }
            info += "Enseignant(s): \n";
            foreach (Enseignant ens in Enseignants)
            {
                info += ens.ToString();
            }
            return info;
        }
    }
}
