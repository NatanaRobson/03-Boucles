namespace exo_3_4_Recherche_diviseur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MESSAGE PROGRAMME

            Console.WriteLine("RECHERCHE DES DIVISEURS D’UN NOMBRE");

            //VARIABLES

            int N;

            //TRAITEMENT

            Console.WriteLine("Entrer N : ");
            N = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= N; i++)
            {
                if(N%i == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}