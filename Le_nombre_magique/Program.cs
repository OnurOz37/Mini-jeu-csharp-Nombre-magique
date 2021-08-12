using System;

namespace Le_nombre_magique
{
    class Program
    {
        

        static int DemanderNombre(int min, int max)
        {

            int nombreUtilisateur = min - 1;

            while (((nombreUtilisateur < min) || (nombreUtilisateur > max)))
            {
                Console.WriteLine("Rentrer un nombre entre " + min + " et " + max + " : ");
                string reponse = Console.ReadLine();
                try
                {
                    nombreUtilisateur = int.Parse(reponse);


                    if ((nombreUtilisateur < min) || (nombreUtilisateur > max))
                    {
                        Console.WriteLine("erreur: le nombre doit etre compris entre " + min + " et " + max);
                    }

                }
                catch (Exception)
                {

                    Console.WriteLine("Rentrer un nombre valide");
                }
            }



            return nombreUtilisateur;

        }
        static void Main(string[] args)
        {
            

            const int NOMBREMIN = 1;
            const int NOMBREMAX = 10;
           
            Random rand = new Random();
            int NOMBRE_MAGIQUE = rand.Next(NOMBREMIN, NOMBREMAX+1); 

           
            int nombre = NOMBRE_MAGIQUE + 1;
            int nbVie = 4; 
            while (nbVie>0)
            {
                Console.WriteLine();
                Console.WriteLine("Il vous reste: " + nbVie + " vies");
                nombre = DemanderNombre(NOMBREMIN, NOMBREMAX);


                if (nombre < NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Mauvaise réponse: " + nombre + " est inférieur au nombre magique, retentez votre chance!");
                    
                }
                else if (nombre > NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Mauvaise réponse: " + nombre + " est supérieur au nombre magique, retentez votre chance!");
                    
                }
                else
                {
                    break; 
                }
                nbVie--;


            }

            if (nombre == NOMBRE_MAGIQUE)
            {
                Console.WriteLine("Bravo " + nombre + " est bien le nombre magique, vous avez gagné!");
            }
            else
            {
                Console.WriteLine("Vous avez perdu, le nombre magique était: " + NOMBRE_MAGIQUE);
            }

            //Avec for 

            /* for(int nbvie =4; nbVie > 0; nbVie--)*/


        }
    }
}
