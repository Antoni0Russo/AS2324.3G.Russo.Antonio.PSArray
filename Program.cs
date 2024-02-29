namespace AS2324._3G.Russo.Antonio.PSArray
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double max = 0;
            int posmax = 0;
            double min = 0;
            int posmin = 0;
            double mediaPonderata = 0;
            Console.WriteLine("imposta quanti voti voi inserire  ");
            int nVoti= Convert.ToInt32(Console.ReadLine());
            int[] pesi = new int[nVoti];
            double[] voti = new double[nVoti];
            StampaVotiPesi(voti, pesi, nVoti);
            
            CaricaVettori(ref voti, ref pesi, nVoti);
            Console.WriteLine("arrray caricato randomicamente ");
            StampaVotiPesi(voti, pesi, nVoti);
            
            StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);
            Console.WriteLine("array   ");
            StampaVotiPesi(voti, pesi, nVoti);

            Console.WriteLine("array  MediaPonderata");
            mediaPonderata = MediaPonderata(voti, pesi, nVoti, ref max, ref posmax, ref min, ref posmin);
            StampaVotiPesi(voti, pesi, nVoti);

            Console.WriteLine("array OrdinaPerVoto ");
            OrdinaPerVoto(ref voti, ref pesi, nVoti);
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
                pesi[i] = random.Next();
                voti[i] =1+ (random.NextDouble()*9);
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
        //riguardare per probabile errore (finire )
        static double MediaPonderata(double[] voti, int[] pesi, int nVoti, ref double max, ref int posmax, ref double min, ref int posmin)
        {
            double contenitoreNumeratore = 0;
            double contenitoreDenominatore = 0;
            for (int i = 0; i < nVoti; i++)
            {
                contenitoreNumeratore = +(voti[i] * pesi[i]);
                contenitoreDenominatore = +voti[i];

            }
            double mediaPonderata = contenitoreNumeratore / contenitoreDenominatore;
            OrdinaPerVoto(ref voti, ref pesi, nVoti);
            for (int i = 0; i < pesi.Length; i++)
            {
                max = pesi[posmax];
                posmax = 0;
                min = pesi[nVoti];
                posmin = nVoti;
            }
            return mediaPonderata;
        }
        double ElencoVotiNellIntorno(double[] voti, int[] pesi, int nVoti, int voto)
        {
           
        }
        static void OrdinaPerVoto(ref double[] voti, ref int[] pesi, int nVoti)
        {
            for (int i = 0; i < nVoti - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < nVoti; j++)
                {
                    if (voti[j] < voti[minIndex])
                    {
                        minIndex = j;
                    }
                }
                double tempVoto = voti[i];
                voti[i] = voti[minIndex];
                voti[minIndex] = tempVoto;


                int tempPeso = pesi[i];
                pesi[i] = pesi[minIndex];
                pesi[minIndex] = tempPeso;



            }

        }
}