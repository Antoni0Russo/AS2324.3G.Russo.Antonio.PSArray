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
            StampaVotiPesi(voti, pesi, nVoti);
            CaricaVettori(ref voti, ref pesi, nVoti);
            Console.WriteLine("arrray caricato randomicamente ");
            StampaVotiPesi(voti, pesi, nVoti);
            StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);
            Console.WriteLine("array  ");
            StampaVotiPesi(voti, pesi, nVoti);

        }
        //riguardare per probabile errore (voti e pesi non sono collegati)
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            for (int i = 0; i < nVoti; i++)
            {
                Console.WriteLine("Voto: " + voti[i] + " - Peso: " + pesi[i]);
            }
        }
        static void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
        {
            Random random = new Random();
            for (int i = 0; i < nVoti; i++)
            {
                pesi[i] = random.Next(1, 11);
                voti[i] = random.Next(0, 101);
            }
        }
        //riguardare per probabile errore (non prende numeri dispari)
        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nVoti)
        {
            for (int i = 0; i < nVoti; i++)
            {
                if (voti[i] % 2 == 1)
                {
                    if (voti[i] >= 4)
                    {
                        Console.WriteLine("Voto: " + voti[i] + " - Peso: " + pesi[i]);
                    }
                }


            }
        }

    }
}