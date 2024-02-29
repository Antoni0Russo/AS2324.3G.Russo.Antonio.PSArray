namespace AS2324._3G.Russo.Antonio.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("imposta quanti voti voi inserire  ");
            int nVoti= Convert.ToInt32(Console.ReadLine());
            int[] pesi = new int[nVoti];
            double[] voti = new double[nVoti];
        }
        void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            for (int i = 0; i < nVoti; i++)
            {
                Console.WriteLine("Voto: " + voti[i] + " - Peso: " + pesi[i]);
            }
        }

    }
}