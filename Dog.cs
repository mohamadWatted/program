using System;
namespace program1
{
    public class Dog:Animals
    {
        public int LeftYears { get; set; }


        public Dog(string name,int age,int leftYears)
            : base(name, age)
        {
            this.LeftYears = leftYears;
        }

        public override string ToString()
        {
            string str = base.ToString() + ",left to live:" + LeftYears+" years";
            return str;
        }
    }
}

