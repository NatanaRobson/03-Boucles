namespace _3_7_Barnabe_fait_ses_courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BARNABÉ FAIT SES COURSES");

            //VARIABLES

            float N;
            int i = 0;

            //TRAITEMENT

            Console.WriteLine("Entrer le budget N de Barnabé :");
            N = Convert.ToInt32(Console.ReadLine());

            while(N > 2)
            {
                i++;
                N = N - (N / 2 + 1);
            }
            
            i++;
            Console.WriteLine("Barnabé à dépensé son budget dans " + i + " magasins !");
        }
    }
}