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

            Student st1 = new Student("yazan", "123", 16);
            Student st2 = new Student("gadir", "456", 15);
            Student st3 = new Student("ahmad", "1234", 16);
            Student st4 = new Student("noor", "123456", 18);
            Student st5 = new Student("mohamad", "012345678", 13);

            //string className = Console.ReadLine();//اسم الصف
            StudentList studentList = new StudentList("1103");


            //current=0

            studentList.AddStudent(st1);
            studentList.AddStudent(st2);
            studentList.AddStudent(st3);
            studentList.AddStudent(st4);
            studentList.AddStudent(st5);



            Console.WriteLine(studentList.ToString());




            Console.ReadKey();

        }
        public static void Fib(int n)
        {
            int temp;
            int index1 = 0, index2 = 1;
            while (index1 + index2 <= n)
            {
                Console.Write(index1 + ",");
                temp = index2;
                index2 = index1 + index2;
                index1 = temp;

            }
            Console.Write(index1 + "," + n + "....");
        }

    }
}