using System;
namespace program1
{//أ
    //i

    public class A
    {
        private int n1;
        private int n2;
    //ii
    //1
        public A()
        {
            this.n1 = 0;
            this.n2 = 0;
        }
     //2
     public A(int n1,int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

     //iii

      //Get/Set
      public int GetN1()
        {
            return this.n1;
        }

       public void SetN1(int n1)
        {
            this.n1 = n1;
        }


        public int GetN2()
        {
            return this.n2;
        }

        public void SetN2(int n2)
        {
            this.n2 = n2;
        }
        //iv
        public void Add(int k)
        {
            this.n1 = this.n1 + k;
            this.n2 = this.n2 + k;
        }

        //v
        //n1+n2=(n1+n2)
        public string ToString()
        {
            return $"{this.n1}+{this.n2}={this.n1+this.n2}";
           // return this.n1 + "+" + this.n2 + "=" + (this.n1 + this.n2);
        }


    }



}

