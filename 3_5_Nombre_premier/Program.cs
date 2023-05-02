namespace _3_5_Nombre_premier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NOMBRE PREMIER");

            //VARIABLES
            int N;
            int i = 0;

            //TRAITEMENT
            Console.WriteLine("Entrer N : ");
            N = Convert.ToInt32(Console.ReadLine());

            for(int test = 1; test <= N ; test++)
            {
                if (N % test == 0)
                {
                    i++;
                }

            }

            if (N==1 || i > 2)
            {
                Console.WriteLine(N + " n'est pas un nbr 1er !");
            }
            else
            {
                Console.WriteLine(N + " est un nbr 1er !");
            }
        }
    }
}