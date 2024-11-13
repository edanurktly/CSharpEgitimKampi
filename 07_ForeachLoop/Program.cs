using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // Foreach (1;2;3;4)
            //1: Değişken Türü
            //2:Değişne adı
            //3:In
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 6910253, 7896, 12, 6, 365, 78954, 26, };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 6910253, 7896, 12, 6, 365, 78954, 26, };
            //foreach (int number in numbers)
            //{
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 45, 6910253, 7896, 12, 6, 365, 78954, 26, };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3, 4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);
            //}







            #endregion

            #region Örnek Sınav Listesi

            Console.Write("****** C # EĞİTİM KAMPI SINAV UYGULAMASI ******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-------------------------------------");
            Console.Write("SINIFINIZDA KAÇ ÖĞRENCİ VAR : ");    
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");


            //öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];


            for(int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. Öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // her öğrenci için 3 sınav notu girişi 

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value; //notları topluyoruz

                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

            }
            
            //sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalamı: {studentExamAvg[i]}");

                //öğrencilerin geçip kalma durumları
                if(studentExamAvg[i] >=50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("---------------------------------------------");
            }


            #endregion


            Console.ReadLine();
        }
    }
}
