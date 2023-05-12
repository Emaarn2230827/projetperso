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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FiggleFonts.Standard.Render("--cegep de jonquiere--"), color:Color.Yellow);
            Cegep cegp = new Cegep();
            bool tours = true;
            while (tours)
            {
                Console.WriteLine("\n ---------- GESTION DU CEGEP ----------", Color.Magenta);
                Console.WriteLine("       ----------------------------", Color.Magenta);
                Console.WriteLine("1- Ajouter un étudiant");
                Console.WriteLine("2- Supprimer un étudiant");
                Console.WriteLine("3- Afficher la liste des étudiants");
                Console.WriteLine("4- Ajouter un enseignant");
                Console.WriteLine("5- Supprimer un enseignant");
                Console.WriteLine("6- Afficher la liste des enseignants");
                Console.WriteLine("7- Ajouter un programme");
                Console.WriteLine("8- Supprimer un programme");
                Console.WriteLine("9- Afficher la liste des programmes");
                Console.WriteLine("q- Quitter");
                char choix = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
                try
                {

                    while (choix != '1' && choix != '2' && choix != '3' && choix != '4' && choix != '5' && choix != '6' && choix != '7' && choix != '8' && choix != '9' && choix != 'q')
                    {

                        throw new Exception("\n #Choix invalide#");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (choix)
                {
                    case '1':
                        Console.Write("Entre le numero de DA de l'etudiant: ");
                        string num = Console.ReadLine();    
                        Console.Write("Entre le nom complet de l'étudiant: ");
                        string nom = Console.ReadLine();
                        Console.Write("Entre son programme: ");
                        string prog = Console.ReadLine();
                        Console.Write("Entre son niveau (0 pour 1ère année, 1 pour 2ème année et 2 pour 3ème année): ");
                        int ann = Convert.ToInt32(Console.ReadLine());
                        Etudiant etu = new Etudiant(num,nom,prog,(Niveau)ann);
                        cegp.AddEtudiant(etu);
                        break;
                    case '2':
                        Console.Write("Entre le numero de DA de l'étudiant à supprimer: ");
                        string da = Console.ReadLine(); 
                        cegp.SuppEtudiant(da);
                      
                        break;
                    case '3':
                        Console.WriteLine("----LISTE DES ETUDIANTS----",color:Color.Magenta);
                        cegp.AfficherListEtu();
                        break;
                    case '4':
                        Console.Write("Entre le code de l'enseignant: ");
                        string codE = Console.ReadLine();
                        Console.Write("Entre le nom complet de l'enseignant: ");
                        string nomEns = Console.ReadLine();
                        Console.Write("Entre son programme: ");
                        string progEn = Console.ReadLine();
                        Console.Write("Entre son statut (0 pour stagiaire et  1 pour permanent): ");
                        int stat = Convert.ToInt32(Console.ReadLine());
                        Enseignant ens = new Enseignant(codE, nomEns, progEn, (Statut)stat);
                        cegp.AddEnseignant(ens);
                        break;
                    case '5':
                        Console.Write("Entre le code de l'enseignant à supprimer: ");
                        string coE = Console.ReadLine();
                        cegp.SuppEnseignant(coE);
                        break;
                    case '6':
                        Console.WriteLine("----LISTE DES ENSEIGNANTS----", color: Color.Magenta);
                        cegp.AfficherListEns();
                        break;
                    case '7':
                        Console.Write("Entre le code du programme: ");
                        string codPr = Console.ReadLine();
                        Console.Write("Entre le nom du programme: ");
                        string nomPro = Console.ReadLine();
                        Programme progr = new Programme(codPr, nomPro);
                        cegp.AddProgramme(progr);
                        break;
                    case '8':
                        Console.Write("Entre le code du programme à supprimer: ");
                        string coP = Console.ReadLine();
                        cegp.SuppProgramme(coP);
                        break;                       
                    case '9':
                        Console.WriteLine("----LISTE DES PROGRAMMES----", color: Color.Magenta);
                        cegp.AfficherListprog();
                        break;
                    case 'q':
                        tours = false;
                        break;
                }
            }
        }
    }
}
