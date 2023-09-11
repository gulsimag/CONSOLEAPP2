using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayi, yuzdeoran,sonuc;
            Console.WriteLine("sayiyi giriniz:");
            sayi= Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("yuzde kaci alinsin");
            yuzdeoran = Convert.ToSingle(Console.ReadLine());
            sonuc = sayi * yuzdeoran / 100;

            Console.WriteLine(sayi+"sayisinin%"+yuzdeoran+"si"+sonuc);





            
            
        }
    }
}
