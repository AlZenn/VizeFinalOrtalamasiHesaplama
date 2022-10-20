using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad;
            Double vize, final, ortalama;

            Console.Write("Adınızı giriniz: ");
            ad = Console.ReadLine();
            Console.Write("Vize notunuzu giriniz: ");
            vize = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final notunuzu giriniz: ");
            final = Convert.ToDouble(Console.ReadLine());

            ortalama = vize * 0.4 + final * 0.6;
            Console.WriteLine("Vize notunuz: "+vize+"\n"+"Final notunuz: "+final+"\n"+ "Ortalamanız: "+ortalama);

            Console.ReadKey();
        }
    }
}
