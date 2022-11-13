using System;
namespace program1
{
    public class StudentList
    {
        private const int MaxSize = 30;
        private Student[] arrStud;
        private string className;
        private int current;
        //int [] arr=new int [10]

        public StudentList(string className)
        {
            this.arrStud = new Student[MaxSize];
            this.className = className;
            this.current = 0;

        }

        public string GetClassName()
        {
            return this.className;
        }
        public void SetClassName(string className)
        {
            this.className = className;
        }
        public void AddStudent(Student newStuentToAdd)
        {
            this.arrStud[this.current] = newStuentToAdd;
            this.current++;
        }

        public override string ToString()
        {
            string str = "\t";

            for(int i = 0; i < this.current; i++)
            {
                str = str + this.arrStud[i].ToString()+"\n\t";
            }
            return str;
        }

    }
}

