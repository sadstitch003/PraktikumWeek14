using System;

namespace PraktikumWeek14
{
    internal class Program
    {
        public static int bilTerakhir = 0;
        public static int bilKe = 0;

        public static bool adalahPrima(int bil)
        {
            if (bil == 1) return true;
            for (int i = 2; i <= Math.Sqrt(bil); i++)
                if (bil % i == 0) return true;

            return false;
        }

        public static int bilPrimaKe(int i)
        {
            var counter = bilKe;
            var bilangan = bilTerakhir;

            while (counter < i)
            {
                bilangan++;
                if (adalahPrima(bilangan))
                    counter++;
            }

            bilKe = i;
            bilTerakhir = bilangan;
            return bilangan;
        }

        public static int bilBukanPrimaKe(int i)
        {
            var counter = bilKe;
            var bilangan = bilTerakhir;

            while (counter < i)
            {
                bilangan++;
                if (adalahPrima(bilangan) == false)
                    counter++;
            }

            bilKe = i;
            bilTerakhir = bilangan;
            return bilangan;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                bilTerakhir = 0;
                bilKe = 0;

                Console.Write("Input : ");
                var N = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Output : ");
                for (int i = 1; i <= N * N; i++)
                {
                    if (i % N == 1) Console.WriteLine();
                    if (adalahPrima(N))
                        Console.Write(String.Format("{0,6}", bilPrimaKe(i)));
                    else
                        Console.Write(String.Format("{0,6}", bilBukanPrimaKe(i)));
                }
                Console.WriteLine("\n");
            }
        }
    }
}