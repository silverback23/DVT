using System;

namespace TipDönüsümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Blinçsiz dönüşüm 
            byte a =5;
            sbyte b=30;
            short c=10;

            int d= a+b+c;
            Console.Write("{0}",d);
            string e="mücahid";
            char f='k';
            object g=e+f;
            Console.Write(g);
             


            //Bilinçli dönüşüm
            int x=4;
            byte y=(byte)x;
            Console.Write("{0}:",y);

            //Tostring methdu
            int xx=6;
            string yy=xx.ToString();
            Console.Write(yy);

            //System.convert

            string s1="10",s2="20";
            int sayi1,sayi2;
            int toplam;
            sayi1=Convert.ToInt32(s1);
            sayi2=Convert.ToInt32(s2);
            toplam= sayi1+sayi2;
            Console.Write("toplam"+toplam);
           
        }
    }
}
