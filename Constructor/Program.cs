using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
//Bu örnekte sizlerden bir Bebek sınıfı tanımlamanız isteniyor.

//Bebek sınıfının propertyleri -> Doğum Tarihi, Ad , Soyad

//Bebek sınıfı için 2 adet constructor tanımlayınız.

//1.si Default Constructor tarzında parametre almayan bir metot.

//2.si Ad ve Soyad parametrelerini alarak newleme işlemi sırasında değerleri propertylere atayan alternatif constructor.

//2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.

//Tanımlama sonrasında her iki constructor ile de birer bebek nesnesi tanımlayarak özelliklerini konsol ekranına yazdırınız.c
    public class Bebek
    {
        public DateTime DogumTarihi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public Bebek()
        {
            DogumTarihi = DateTime.Now;   
            
        }

        public Bebek(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = DateTime.Now;   
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Bebek bebek1 = new Bebek();
            bebek1.Ad = "Ali";       
            bebek1.Soyad = "Yılmaz"; 

            
            Bebek bebek2 = new Bebek("Ayşe", "Demir");

            Console.WriteLine("Ingaaaa");
            Console.WriteLine("\nBebek 1 Bilgileri:");
            bebek1.PrintInfo();

            Console.WriteLine("\nIngaaaa");
            Console.WriteLine("\nBebek 2 Bilgileri:");
            bebek2.PrintInfo();
            Console.ReadKey();
        }
    }
}
