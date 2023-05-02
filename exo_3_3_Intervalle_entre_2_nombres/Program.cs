namespace exo_3_3_Intervalle_entre_2_nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MESSAGE PROGRAMME

            Console.WriteLine("INTERVALLE ENTRE 2 NOMBRES");

            //VARIABLES

            int A;
            int B;
            int temp;
            
            //TRAITEMENT

          
            Console.WriteLine("Entrer A : ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer B : ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine);

            if (A > B)
            {
                temp = A;
                A = B;
                B = temp;
            }

            for (int i = (A+1); i < B; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}