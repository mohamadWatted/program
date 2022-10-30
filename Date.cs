using System;
namespace program1
{
    public class Date
    {


        private int day;
        private int month;
        private int year;
        private int number;
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
     

        public Date()
        {

        }

        public int GetDay()
        {
            return this.day;
        }

        public void SetDay(int day)
        {
            this.day = day;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public void SetMonth(int month)
        {
            this.month = month;
        }



        public int GetYear()
        {
            return this.year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public string ToString()
        {
            return this.day + "/" + this.month + "/" + this.year;
        }

        public int Compare(Date other)
        {
            if (this.year != other.year)
                return this.year - other.year;
            if (this.month != other.month)
                return this.month - other.month;
            return this.day - other.day;
        }

    }
}


