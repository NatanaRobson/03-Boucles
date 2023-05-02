namespace _3_6_Jeu_de_la_fourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JEU DE LA FOURCHETTE");

            //VARIABLES

            Random nbr = new Random();
            int R = nbr.Next(0, 101);
            int min = 0;
            int max = 100;
            int i = 0;
            int N;

            //TRAITEMENT

            do
            {
                Console.WriteLine(Environment.NewLine + "Entrer un nbr N, entre " + min + " et " + max + " :");
                N = Convert.ToInt16(Console.ReadLine());

                i++;

                if (R > N)
                {
                    min = N;
                }
                else
                {
                    max = N;
                }
            }
            while (N != R);

            Console.WriteLine("Bravo !!! Vous avez trouvé en " + i + " essais !");
        }
    }
}