using System;
/*
created Irmayuni Manulang - 2207111393
*/

namespace DASARPEMOGRAMAN
{

    class Program
    {
        //Main Method
        static void Main(string[] args)
        {
            int Kesempatan = 3;
            //Invoke function/method 
            Intro();
            //bool bGameSelesai = PlayGame();
            while (Kesempatan > 0)
            {
                PlayGame();
                Kesempatan = Kesempatan - 1;
            }
        }

        static void Intro()
        {
            //Intro
            Console.WriteLine("Anda adalah aggen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak di ketahui..");
        }

        static bool PlayGame()
        {
            //Deklarasi Variabel
            int kodeA;
            int kodeB;
            int kodeC;
            int jumlahKode;
            String tebakanA;
            String tebakanB;
            String tebakanC;

            int hasilTambah;
            int hasilKali;

            //Buat Random Number Generator (RNG)
            Random rng = new Random();

            //Insialisasi Variabel
            kodeA = rng.Next(1, 3);
            kodeB = rng.Next(1, 3);
            kodeC = rng.Next(1, 3);
            jumlahKode = 3;

            //Oprasi Aritmatika
            hasilTambah = kodeA + kodeB + kodeC;
            hasilKali = kodeA + kodeB + kodeC;

            //Intro();
            Console.WriteLine("Password terdiri dari " + jumlahKode + " angka");
            Console.WriteLine("jika ditambahkan hasilnya " + hasilTambah);
            Console.WriteLine("jika dikalikan hasilnya " + hasilKali);



            //Input User
            Console.Write("Masukan Kode Pertama : ");
            tebakanA = Console.ReadLine();
            Console.Write("Masukan Kode Kedua : ");
            tebakanB = Console.ReadLine();
            Console.Write("Masukan Kode Ketiga : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan Anda : " + tebakanA + " " + tebakanB + " " + tebakanC + " ?"(ya / tidak));

            //Konfirmasi
            String konfirmasi = Console.ReadLine();
            if (konfirmasi == "y")
            {
                //Logic
                if (tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString())
                {
                    Console.WriteLine("Tebakan anda Benar...");
                    //return true;
                }
                else
                {
                    Console.WriteLine("Tebakan anda Salah!");
                    Console.WriteLine("kode yang benar adalah " + kodeA + " " + kodeB + " " + kodec + ".");
                    //return false;
                }
            }
            else
            {
                //PlayGame();
            }
        }
    }
}
