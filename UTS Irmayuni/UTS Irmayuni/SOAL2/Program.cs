using System;

namespace TebakAngka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool bermainLagi = true;
            int min = 1;
            int max = 100;
            int tebak;
            int angka;
            int tebakan;
            String tanggapan;

            while (bermainLagi)
            {
                tebak = 0;
                tebakan = 0;
                tanggapan = "";
                angka = random.Next(min, max + 1);

                while (tebak != angka)
                {
                    Console.Write("Tebak sebuah angka antara " + min + " - " + max + " : ");
                    tebak = Convert.ToInt32(Console.ReadLine());

                    if (tebak > angka)
                    {
                        Console.WriteLine("Salah. Nilai terlalu tinggi !");
                    }
                    else if (tebak < angka)
                    {
                        Console.WriteLine("Salah. Nilai terlalu rendah !");
                    }
                    tebakan++;
                }
                Console.WriteLine("Angka : " + angka);
                Console.WriteLine("Kamu menang !");
                Console.WriteLine("Tebakan : " + tebakan);

                Console.WriteLine("Apakah kamu ingin bermain lagi ? (y/n) : ");
                tanggapan = Console.ReadLine();
                tanggapan = tanggapan.ToUpper();

                if (tanggapan == "y")
                {
                    bermainLagi = true;
                }
                else
                {
                    bermainLagi = false;
                }
            }

            Console.WriteLine("Terima kasih sudah bermain game tebak angka !");

            Console.ReadKey();
        }

    }
}