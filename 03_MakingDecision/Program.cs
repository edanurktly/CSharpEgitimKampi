﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi  giriniz :");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine("sayıyı giriniz:");
            //number=int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result =" Hata!";

            //Console.WriteLine("Sınav 1 :");
            //exam1=int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav 2:");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav 3 :");
            //exam3 = int.Parse(Console.ReadLine());

            //average= (exam1+exam2 +exam3) /3 ;
            //Console.WriteLine("Sınavların ortalaması : " +average);

            //if(average > 0 & average <=50 )
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız :");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.WriteLine("Lütfen kullanıcı adını giriniz :");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz ");
            //}


            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);


            //Console.WriteLine("lütfen 1.sayıyı giriniz :");
            //int number1=int.Parse(Console.ReadLine());

            //Console.WriteLine("lütfen 2.sayıyı giriniz :");
            //int number2 = int.Parse(Console.ReadLine());

            //int result= number1 % number2;

            //Console.WriteLine("1.Sayının 2.sayıya bölümünden kalan : " + result);   

            //Console.WriteLine("LÜTFEN SAYIYI GİRİNİZ :");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region  Char Değişkenler İle Karar Yapıları
            //char team;
            //Console.WriteLine("Takım sembolünü giriniz :");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team =='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("******  C # Eğitim Kapı Restoran  ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("1- Ana Yemekler ");
            //Console.WriteLine("2- Çorbalar ");
            //Console.WriteLine("3- Pizzalar ");
            //Console.WriteLine("4- İçeçcekler ");
            //Console.WriteLine("5- Tatlılar ");
            //Console.WriteLine("------------------------");
            //Console.WriteLine();


            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menü seçiniz : ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Ana Yemekler --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("-------- Ana Yemekler --------");


            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Çorbalar --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek ");
            //    Console.WriteLine("2- Ezogelin");

            //    Console.WriteLine("-------- Çorbalar --------");


            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Pizzalar  --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine("3- Tavuklu Pizza ");

            //    Console.WriteLine("-------- Pizzalar   --------");

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- İçecekler  --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Su");
            //    Console.WriteLine("3- Ayran ");

            //    Console.WriteLine("-------- İçecekler    --------");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------- Tatlılar  --------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Trileçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç ");

            //    Console.WriteLine("-------- Tatlıalr    --------");
            //}
            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay girişi yapınız :" );
            //int montNumber = int.Parse( Console.ReadLine() );

            //switch (montNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran");break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //        default: Console.WriteLine("Hatalı veri girişi "); break ;

            //}

            #endregion

            #region Switch Case Hesap Makinesi
            //int number1 , number2, result;
            //char symbol;

            //Console.WriteLine("1.sayıyı giriniz :");
            //number1=int.Parse(Console.ReadLine());

            //Console.WriteLine("2.sayıyı giriniz :");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen Yapmak istediğiniz işlemi giriniz : ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result= number1 + number2;
            //        Console.WriteLine("Toplam : " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark : " + result);
            //        break;

            //    case '*':
            //        result = number1 *  number2;
            //        Console.WriteLine("Çarpım : " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm : " + result);
            //        break;
            //}

            #endregion

            Console.ReadLine();
        }
    }
}
