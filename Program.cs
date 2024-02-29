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
            StampaVotiPesi(pesi[], voti[],nVoti );
        }
        //riguardare per probabile errore (voti e pesi non sono collegati)
        void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            for (int i = 0; i < nVoti; i++)
            {
                Console.WriteLine("Voto: " + voti[i] + " - Peso: " + pesi[i]);
            }
        }
        void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
        {
            Random random = new Random();
            for (int i = 0;i < nVoti;i++)
            {
                pesi[i] = random.Next(1, 11);
                voti[i] = random.Next(0, 101); 
            }
        }

    }
}