using System.ComponentModel.DataAnnotations;

namespace exo_3_1_Controle_de_la_saisie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MESSAGE PROGRAMME

            Console.WriteLine("CONTRÔLER LA SAISIE");

            //VARIABLES

            string prenom;

            //TRAITEMENT

            do
            {
                Console.WriteLine("Entrer votre prénom : ");
                prenom = Console.ReadLine();
                Console.WriteLine("Bonjour " + prenom + "!");
            }
            while (prenom.Length <= 2);
            

        }
    }
}