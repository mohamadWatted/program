using System;
namespace program1
{
    public class Student
    {
        private string name;
        private string id;
        private int age;

        public Student()
        {

        }

        public Student(string name,string id,int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;

        }

        public string GetName()
        {
            return this.name;
        }


        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetId()
        {
            return this.id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        public override string ToString()
        {
            return $"ID:{this.id},Student name:{this.name},age:{this.age}";
        }

    }
}

