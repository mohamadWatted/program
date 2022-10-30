using System;
namespace program1
{
    public class Time
    {
     
          private int hour;
          private int minute;

        public Time(int hour,int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }
        public int GetHour()
        {
            return this.hour;
        }

        public void SetHour(int hour)
        {
            this.hour = hour;
        }


        public int GetMinute()
        {
            return this.minute;
        }

        public void SetMinute(int minute)
        {
            this.minute = minute;
        }

        public string ToString()
        {
            return this.hour + ":" + this.minute;
        }
        //hh:mm

    }
    }
}

