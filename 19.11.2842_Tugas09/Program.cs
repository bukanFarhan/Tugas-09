using System;

namespace _19._11._2842_Tugas09
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("Pilih printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("Nomor printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else if (nomorPrinter == 3)
                printer = new LaserJet();
            else
                printer = new Salah();

            printer.Show();
            printer.Print();

            Console.ReadKey();
        }
    }
}
