using System;

namespace ForLoop__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0, i, j, k;
            string input;

            Console.Write("Masukkan Jumlah Angka Yang Ingin Ditampilkan  : "); j = Convert.ToInt32(input = Console.ReadLine());
            Console.Write("Dimulai Dari angka 1 atau 0                   : "); k = Convert.ToInt32(input = Console.ReadLine());

            BB();

            switch(k)
            {
                case 0:
                    h = 0;
                    break;
                case 1:
                    h = 1;
                    break;
                default:
                    BB();
                    Console.WriteLine("Dimulai dari angka, hanya diizinkan 1 atau 0 saja.");
                    Console.ReadLine();
                    break;
            }

                for (i = h; i <= j; i++)
                {
                    Console.WriteLine("Nilai i = " + i);
                }

            Console.ReadLine();
        }

        static void BB()
        {
            Console.WriteLine();
        }
    }
}
