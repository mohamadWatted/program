using System;
namespace program1
{
    public class Animals
    {


        public string Name { get; set; }
        public int Age { get; set; }
        public Animals(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }


        public override string ToString()
        {
            return "The name is:"+Name + ",and the age is:" + Age;
        }
    }
}

