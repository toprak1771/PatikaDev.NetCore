using System;
using System.Collections.Generic;
using System.Text;

namespace PatikaMethods.PatikaMethods
{
    class Class1
    {
        static void Main2(string[] args)


        {
            string number = "333";
            bool result = int.TryParse(number, out int outNumber);
            if (result)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outNumber);
            }

            else
            {
                Console.WriteLine("Başarısız");
            }


            Methods instance = new Methods();
            instance.Sum(4, 5, out int result2);
            Console.WriteLine(result2);

            //Metot Aşırı Yükleme

            int number3 = 173435;
            instance.WriteScreen(Convert.ToString(number3));
            instance.WriteScreen(number3);
            instance.WriteScreen("Toprak", "Tüzün");


        }


    }

    class Methods
    {
        public void Sum(int a, int b, out int result)
        {
            result = a + b;
        }

        public void WriteScreen(string data) 
        {
            Console.WriteLine(data);        
        }
        public void WriteScreen(int data)
        {
            Console.WriteLine(data);
        }

        public void WriteScreen(string data1, string data2)
        {
            Console.WriteLine(data1 + data2);
        }
    }
}
    
