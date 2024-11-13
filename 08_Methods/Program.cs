using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //() 
            //Geriye Değer Döndürmeyen Metotlar
            //Customer --> Listele,ekle,sil , güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali yıldız");
            //    Console.WriteLine("edanur ktly");
            //    Console.WriteLine("merve çınar");
            //}

            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y=2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}

            //Sum();


            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet yıldırım");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+ name + " " + surName);
            //}
            //#endregion

            //CustomerCard("Mehmet", "Yıldız");

            #endregion

            #region  Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(2,3,6);
            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "kaya";

            //   return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion

            #region  Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo="Ülke: "+countryName+"  - Başkent: "+capital+"-Bayrak Rengi:  "+ flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();

            //Console.WriteLine("Başkenti Giriniz: ");
            //y= Console.ReadLine();

            //Console.WriteLine("Bayrak Rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine( CountryCard(x, y, z));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int  Sum(int number1, int number2) 
            //{
            //    int result=number1+number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 95));
            //Console.WriteLine(Sum(36,47));


            #endregion

            #region Örnek Uygulama
            //string ExamResult(string student, int exam1, int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti" + "Ortalama: " +result;
            //    }
            //    else
            //    {
            //        return student + "Öğrenci başarısız oldu" + "Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali",25,41,85));

            #endregion


            Console.Read();

        }
    }
}
