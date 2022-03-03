using System;

namespace PatikadevExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reküfsif Fonksiyonlar

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);
            Islemler example= new Islemler();
            Console.WriteLine(example.Expo(3, 4));

            

            
        }
    }

    public class Islemler 
    { 
        public int Expo(int sayi,int üs) 
        {
            if (üs < 2)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;

            
        }
    }
}
