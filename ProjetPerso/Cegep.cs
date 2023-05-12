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
    internal class Cegep
    {
        public List<Programme> ProgrammeList { get; set; }
        public List<Etudiant> Etudiants { get; set; }
        public List<Enseignant> Enseignants { get; set; }   

        public Cegep()
        {
            ProgrammeList = new List<Programme>();
            CreerProg();
            Etudiants = new List<Etudiant>();
            CreerEtu();
            Enseignants = new List<Enseignant>();
            CreerEns();

        }   

        public void CreerProg()
        {
            List<Etudiant> etudiantsInf = new List<Etudiant>();
            etudiantsInf.Add(new Etudiant("2230806", "Lucas Tremblay", "Technique de l'informatique",Niveau.annee1));
            etudiantsInf.Add(new Etudiant("2230807", "Joel Racine", "Technique de l'informatique",Niveau.annee2));
            etudiantsInf.Add(new Etudiant("2230808", "Caroline Cyr", "Technique de l'informatique",Niveau.annee1));
            List<Enseignant> enseignantsInf = new List<Enseignant>();
            enseignantsInf.Add(new Enseignant("2305", "Arnold Ema", "Technique de l'informatique", Statut.permanent));
            ProgrammeList.Add(new Programme("1221","Art numérique"));  
            ProgrammeList.Add(new Programme("1222","Genie électrique"));  
            ProgrammeList.Add(new Programme("1223","Genie industriel"));  
            ProgrammeList.Add(new Programme("1224","Technique de l'informatique",etudiantsInf,enseignantsInf));  
            ProgrammeList.Add(new Programme("1225","Soins infirmier"));  
        }
        public void CreerEns()
        {
            Enseignants.Add(new Enseignant("2301","Lucie Bouchard","Art numérique",Statut.permanent));
            Enseignants.Add(new Enseignant("2302","Thomas Tremblay","Genie industriel",Statut.permanent));
            Enseignants.Add(new Enseignant("2303","Nicolas Grimp","Soins infirmier",Statut.stagiaire));
            Enseignants.Add(new Enseignant("2304","Leonard Brown","Art numérique",Statut.stagiaire));
            Enseignants.Add(new Enseignant("2305","Arnold Ema","Technique de l'informatique",Statut.permanent));
        }
        public void CreerEtu()
        {
            Etudiants.Add(new Etudiant("2230801","Lucas simard","Genie électrique",Niveau.annee1));
            Etudiants.Add(new Etudiant("2230802","Yan fortin","Genie électrique", Niveau.annee1 ));
            Etudiants.Add(new Etudiant("2230803","Mathieu boily", "Soins infirmier", Niveau.annee2));
            Etudiants.Add(new Etudiant("230804","Bill lapointe", "Genie industriel", Niveau.annee1));
            Etudiants.Add(new Etudiant("2230805","kathy Deschamps", "Art numérique", Niveau.annee3));
            Etudiants.Add(new Etudiant("2230806","Lucas Tremblay", "Technique de l'informatique", Niveau.annee1));
            Etudiants.Add(new Etudiant("2230807","Joel Racine", "Technique de l'informatique", Niveau.annee2));
            Etudiants.Add(new Etudiant("2230808","Caroline Cyr", "Technique de l'informatique", Niveau.annee1));
            Etudiants.Add(new Etudiant("2230809","Eli Fortin","Genie industriel", Niveau.annee2 ));

        }

        public void AddProgramme(Programme prog)
        {
            bool verif = false;
            foreach (Programme progr in ProgrammeList)
            {
                if (progr.CodeProgr == prog.CodeProgr)
                {
                    verif = true;
                }

            }
            if (!verif)
            {
                ProgrammeList.Add(prog);
                Console.WriteLine("##Enregistrement fait :) ##", color: Color.Green);
            }
            else
            {
                Console.WriteLine("Impossible d'enregistré ce programme car son code est déjà utilisé ", color: Color.Red);
            }
        }

        public void SuppProgramme(string code)
        {
            bool verif = false;
            Programme prg = new Programme("", "");
            foreach (Programme prog in ProgrammeList)
            {
                if (prog.CodeProgr == code)
                {
                    prg = prog; 
                    verif = true;
                }

            }
            if (!verif)
            {
                Console.WriteLine("Ce programme n'existe pas :(", color: Color.Red);
            }
            else
            {
                ProgrammeList.Remove(prg);
                Console.WriteLine("##Suppression faite :) ##", color: Color.Green);
            }
        }  

        public void AddEtudiant(Etudiant etu)
        {
            bool verif = false;
            foreach (Etudiant etud in Etudiants)
            {
                if (etud.NumDa == etu.NumDa)
                {
                    verif = true;
                }

            }
            if (!verif)
            {
                Etudiants.Add(etu);
                Console.WriteLine("##Enregistrement fait :) ##", color: Color.Green);
            }
            else
            {
                Console.WriteLine("Impossible d'enregistré cet étudiant car son DA est déjà utilisé ", color: Color.Red);
            }

        }
        public void SuppEtudiant(string da)
        {
            bool verif = false;
            Etudiant etudt = new Etudiant("","","",Niveau.annee1);
            foreach(Etudiant etu in Etudiants)
            {
                if(etu.NumDa == da)
                {
                    etudt = etu;
                    verif = true;
                }            

            }
            if(!verif)
            {
                Console.WriteLine("Cet etudiant n'existe pas :(",color:Color.Red);
            }
            else
            {
                Etudiants.Remove(etudt);
                Console.WriteLine("##Suppression faite :) ##", color:Color.Green);
            }

         
        }
        public void AddEnseignant(Enseignant ens)
        {
            bool verif = false;
            foreach (Enseignant ensg in Enseignants)
            {
                if (ensg.CodeEns == ens.CodeEns)
                {
                    verif = true;
                }

            }
            if (!verif)
            {
                Enseignants.Add(ens);
                Console.WriteLine("##Enregistrement fait :) ##", color: Color.Green);
            }
            else
            {
                Console.WriteLine("Impossible d'enregistré cet enseignant car son code est déjà utilisé ", color: Color.Red);
            }
        }
        public void SuppEnseignant(string code)
        {
            bool verif = false;
            Enseignant ensg = new Enseignant("", "", "", Statut.stagiaire);
            foreach (Enseignant ens in Enseignants)
            {
                if (ens.CodeEns == code)
                {
                    ensg = ens; 
                    verif = true;
                }

            }
            if (!verif)
            {
                Console.WriteLine("Cet enseignant n'existe pas :(", color: Color.Red);
            }
            else
            {
                Enseignants.Remove(ensg);
                Console.WriteLine("##Suppression faite :) ##", color: Color.Green);
            }
        }

        public void AfficherListEtu()
        {
            foreach(Etudiant etu in Etudiants)
            {
                Console.WriteLine(etu.ToString(),color:Color.Yellow);  
            }
        }
        public void AfficherListEns()
        {
            foreach (Enseignant ens in Enseignants)
            {
                Console.WriteLine(ens.ToString(), color: Color.Yellow);
            }
        }
        public void AfficherListprog()
        {
            foreach (Programme prog in ProgrammeList)
            {
                Console.WriteLine(prog.ToString(), color: Color.Yellow);
            }
        }

    }
}
