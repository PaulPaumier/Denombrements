using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * titre : Denombrements
 * description : programme permettant d'effectuer des calculs de permutation, d'arrangement et de combinaison
 * auteur : Entreprise cliente
 * date de création : 21/11/2023
 * date de dernière modification : 21/11/2023
 */

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="premierMessage"></param>
        /// <returns>resultat de la permutation</returns>
        static long Permutation(string premierMessage)
        {
            // Déclaration
            long resultat = 1;
            // Saisie du nombre d'éléments à gérer
            Console.Write(premierMessage);
            int nombreElement = int.Parse(Console.ReadLine());
            // calcul de r                              
            for (int k = 1; k <= nombreElement; k++)
                resultat *= k;
            //Affichage du résultat
            Console.WriteLine(nombreElement + "! = " + resultat);
            return resultat;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="premierMessage"></param>
        /// <param name="deuxiemeMessage"></param>
        /// <returns>resultat de l'Arrangement</returns>
        static long Arrangement(string premierMessage, string deuxiemeMessage)
        {
            // Déclaration
            long resultat = 1;
            // Saisie du nombre d'éléments à gérer
            Console.Write(premierMessage);
            int nombreEnsemble = int.Parse(Console.ReadLine());
            // Saisie du nombre d'éléments dans le sous ensemble
            Console.Write(deuxiemeMessage);
            int nombreSousEnsemble = int.Parse(Console.ReadLine());
            // calcul du résultat
            for (int k = (nombreEnsemble - nombreSousEnsemble + 1); k <= nombreEnsemble; k++)
                resultat *= k;
            // Affichage du résultat
            Console.WriteLine("A(" + nombreEnsemble + "/" + nombreSousEnsemble + ") = " + resultat);
            return resultat;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="premierMessage"></param>
        /// <param name="deuxiemeMessage"></param>
        /// <returns>resultat de la combinaison</returns>
        static long Combinaison(string premierMessage, string deuxiemeMessage)
        {
            // Déclaration
            long resultat1 = 1;
            long resultat2 = 1;
            // Saisie du nombre d'éléments à gérer
            Console.Write(premierMessage);
            int nombreEnsemble = int.Parse(Console.ReadLine());
            // Saisie du nombre d'éléments dans le sous ensemble
            Console.Write(deuxiemeMessage);
            int nombreSousEnsemble = int.Parse(Console.ReadLine());
            // calcul de r1
            for (int k = (nombreEnsemble - nombreSousEnsemble + 1); k <= nombreEnsemble; k++)
                resultat1 *= k;
            // calcul de r2
            for (int k = 1; k <= nombreSousEnsemble; k++)
                resultat2 *= k;
            // Affichage du résultat
            Console.WriteLine("C(" + nombreEnsemble + "/" + nombreSousEnsemble + ") = " + (resultat1 / resultat2));
            return (resultat1 / resultat2);
        }

        static void Main(string[] args)
        {
            int choix = 1;
            // Boucle de choix de calcul
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        // Fonction Permutation
                        Permutation("nombre total d'éléments à gérer = ");
                        break;
                    case 2:
                        // Fonction Arrangement
                        Arrangement("nombre total d'éléments à gérer = ", "nombre d'éléments dans le sous ensemble = ");
                        break;
                    default :
                        // Fonction Combinaison
                        Combinaison("nombre total d'éléments à gérer = ", "nombre d'éléments dans le sous ensemble = ");
                        break;
                }
            }
            
        }
    }
}
