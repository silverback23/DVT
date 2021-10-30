using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli atama
            int x=3;
            int y=3;
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            
            Console.WriteLine(x);

            //Mantıksal operatörler
            //||, &&, !
            bool isS =true;
            bool isCo=false;
            if (isS&&isCo)
            Console.WriteLine("perfect");

            //İlişkisel operatörler
            int a=3;
            int b;4;
            bool sonuc =a<b;
            Console.WriteLine(sonuc);
            sonuc=a>b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;

            ///,*,-,+,%

            int sayi1=10;
            int sayi2 =5;
            int sonuc1=sayi1/sayi2;
            int sonuc2=sayi1+sayi2;
            int sonuc3=sayi1*sayi2;
            int sonuc4=sayi1-sayi2;
            Console.WriteLine("sonuçlar{0},{1},{2},{3}",sonuc1,sonuc2,sonuc3,sonuc4);
            





        }
    }
}
