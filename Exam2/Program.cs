using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayının 10 Eksiğinin 20 Fazlasının 2'ye bölümünden kalanın karesi kaçtır?
            //Kullanıcıdan sayı al
            Console.WriteLine("Lütfen bir tam sayı giriniz:");
            
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            // sayının 10 eksiği
            sayi1 = sayi1-10;
            Console.WriteLine($@"Girdiğiniz sayının 10 eksiği: {sayi1}");
            //sayının 20 fazlası
            sayi1 = sayi1+20;
            Console.WriteLine($@"Girğiniz sayının 10 eksiğinin 20 fazlası: {sayi1}");
            //sayının mod 2 si
            sayi1 = sayi1 % 2;
            Console.WriteLine($@"Girğiniz sayının 10 eksiğinin 20 fazlasının mod 2 si: {sayi1}");
            // modun karesi
            sayi1 = sayi1 * sayi1;
            Console.WriteLine($@"Girğiniz sayının 10 eksiğinin 20 fazlasının mod 2 sinin karesi: {sayi1}");






            Console.ReadLine();

        }
    }
}
