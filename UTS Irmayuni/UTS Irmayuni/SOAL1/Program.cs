//Irmayuniii - 2207111393
using System;

namespace Nametag
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Nama            :\n");
            string name = Console.ReadLine();
            Console.Write("NIM             :\n");
            string NIM = Console.ReadLine();
            Console.Write("Konsentrasi     :\n");
            string konsentrasi = Console.ReadLine();

            Console.WriteLine("|*******************************|");
            Console.WriteLine("|Nama    :          \t{0} \t|", name);
            Console.WriteLine("|                   \t{0} \t|", NIM);
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("|                      \t{0} \t|", konsentrasi);
            Console.WriteLine("|*******************************|");
            Console.ReadLine();
        }
    }
}
