using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //Döngüler 1+2+3+4+5+6
            //3+3=6+4=10

            //For(x;y;z;)
            //x: başlangıç değeri
            //y:bitiş değeri
            //z:artış - azalış

            //int i;

            //for ( i = 1; i <=5; i++)
            //{
            //    Console.WriteLine( "C# Eğitim Kampı");

            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi giriniz :");
            //int finisValue=int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finisValue; i++)
            //{
            //    Console.WriteLine("yaşasın Cumhuriyet");
            //}



            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0) 
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda : " + bacterium);
            //}

            #endregion


            #region While Döngüsü

            //while (şart)
            //{
            //    işlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <=10)
            //{
            //    if(i%3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);
            #endregion


            #region Örnek sınav sorusu

            // klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan  kodu yazınız

        //    Console.WriteLine("3 basamaklı sayı girişi yapınız : ");
        //   int  number=Convert.ToInt32(Console.ReadLine());

        //    int ones, tens, hundred;

        //    int sum;

        //    ones = number % 10;
        //    hundred = number / 100;
        //    tens =( number % 100)/10;

        //sum= ones + hundred + tens;
        //    Console.WriteLine(sum);

           

            #endregion

            Console.Read();
        }
    }
}
