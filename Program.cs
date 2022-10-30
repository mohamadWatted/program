using System;
using System.Threading;
using prog;
using program1;
namespace prog
{
    class Program
    {


        static void Main(string[] args)
        {
            Date d1 = new Date(12, 10, 2021);
            Date d2 = new Date(24, 10, 2022);
            Date d3 = new Date(24, 10, 2022);

            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());

            d1.SetDay(20);
            d2.SetMonth(d1.GetMonth());

            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());

            //    Date d3 = new Date(24, 10, 2022);

            int value1 = d1.Compare(d2);
            if (value1==0)
                Console.WriteLine("Is equals:"+value1);
            else
                Console.WriteLine("Is not equals:"+value1);

            int value2 = d2.Compare(d3);
            if (value2 == 0)
                Console.WriteLine("Is equals:" + value2);
            else
                Console.WriteLine("Is not equals:" + value2);

            Console.ReadKey();

        }


    }
}