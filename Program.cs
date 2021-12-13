using System;

namespace PraktikumWeek14
{
    internal class Program
    {
        public static bool adalahPrima(int bil)
        {
            var jumlahFaktor = 0;
            for (int i = 1; i <= bil; i++)
                if (bil % i == 0) jumlahFaktor++;

            if (jumlahFaktor == 2) return true;
            else return false;
        }

        public static int bilPrimaKe(int i)
        {
            var counter = 0;
            var bilangan = 0;

            while (counter < i)
            {
                bilangan++;
                if (adalahPrima(bilangan))
                    counter++;
            }
            return bilangan;
        }

        public static int bilBukanPrimaKe(int i)
        {
            var counter = 0;
            var bilangan = 0;

            while (counter < i)
            {
                bilangan++;
                if (adalahPrima(bilangan) == false)
                    counter++;
            }
            return bilangan;
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input : ");
                var N = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

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
