using System;

namespace PatikaMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 34;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int result = a + b;
            Console.WriteLine(a + b);

            Console.WriteLine(Sum(a, b));


            static int Sum(int value1, int value2)
            {
                return value1 + value2;
            }

            Methods example = new Methods();
            example.WriteScreen(Convert.ToString(result));
           
            int result2 = example.PlusandSum(ref a, ref b);
            example.WriteScreen(Convert.ToString(result2));
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }

    class Methods
    {
       public void WriteScreen(string data)
        {
            Console.WriteLine(data);

        }

       public int PlusandSum(ref int value1,ref int value2) 
        {
            value1 += 1;
            value2 += 1;
            return value1 + value2;
        }
    }
}