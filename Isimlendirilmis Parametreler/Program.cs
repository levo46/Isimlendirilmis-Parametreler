using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isimlendirilmis_Parametreler
{
    class SayiIslemler
    {
        public int Topla(int Sayi1, int Sayi2,int Sayi3)
        {
            return (Sayi1 + Sayi2 + Sayi3);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiIslemler sayiIslemler = new SayiIslemler();
            int Topla=sayiIslemler.Topla(Sayi1:10,Sayi2:5,Sayi3:15);
            Console.WriteLine("Toplam:{0}",Topla);
        }
    }
}
