using System;
using System.Collections.Generic;
using System.Text;

namespace _19._11._2842_Tugas09
{
    public class PrinterWindows
    {
        public virtual void Show()
        {

        }
        public virtual void Print()
        {

        }
    }

    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nEpson display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }

    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nCanon display dimension : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon printer printing....");
        }
    }

    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nLaserJet display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }

    public class Salah : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("\nDisplay dimension : not detected");
        }
        public override void Print()
        {
            Console.WriteLine("Printer not detected");
        }
    }
}
