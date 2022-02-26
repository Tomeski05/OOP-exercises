using Microsoft.Extensions.Logging;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace More_Exercises_on_Classes.MyDate
{
    public class MyDate
    {

        private int year;
        private int month;
        private int day;

        public MyDate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public int getYear()
        {
            return year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public int getMonth()
        {
            return month;
        }

        public void setMonth(int month)
        {
            this.month = month;
        }

        public int getDay()
        {
            return day;
        }

        public void setDay(int day)
        {
            this.day = day;
        }

        public string toString()
        {
            string dateString = string.Format("%d-%d-%d", year, month, day);
            Date date = null;
            try
            {
                date = new SimpleDateFormat("yyyy-MM-dd").parse(dateString);
            }
            catch (ParseException ex)
            {
                Logger.getLogger(MyDate.class.getName()).log(Level.SEVERE, null, ex);
            }
                dateString = new SimpleDateFormat("EEEE d MMM yyyy").format(date);
                return dateString;
            }

        public MyDate nextYear()
        {
            this.year++;
            return this;
        }

        public MyDate nextMonth()
        {
            this.month++;
            return this;
        }

        public MyDate nextDay()
        {
            this.day++;
            return this;
        }

        public MyDate previousYear()
        {
            this.year--;
            return this;
        }

        public MyDate previousMonth()
        {
            this.month--;
            return this;
        }

        public MyDate previousDay()
        {
            this.day--;
            return this;
        }
    }

        class TestMyDate
        {

            public static bool isLeapYear(int year)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                if (year % 4 == 0 && year % 100 != 0)
                {
                    return true;
                }
                return false;
            }

            public static bool isValidDate(int year, int month, int day)
            {
                string dateString = string.Format("%d-%d-%d", year, month, day);
                SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");
                dateFormat.setLenient(false);
                try
                {
                    dateFormat.Parse(dateString);
                }
                catch (ParseException pe)
                {
                    return false;
                }
                return true;
            }

            public static int getDayOfWeek(int year, int month, int day)
            {
                string[] weeks = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

                string dateString = string.Format("%d-%d-%d", year, month, day);
                Date date = null;
                try
                {
                    date = new SimpleDateFormat("yyyy-MM-dd").Parse(dateString);

                }
                catch (ParseException ex)
                {
                    Logger.getLogger(MyDate.class
                                    .getName()).log(Level.SEVERE, null, ex);
                }   
        
                dateString = new SimpleDateFormat("EEEE").Format(date);
                int d = 0;
                for (string week: weeks)
                {
                    if (week.Equals(dateString)) break;
                    d++;
                }
                return d;
            }

            public static void main(string[] args)
            {
                MyDate d1 = new MyDate(2012, 2, 28);
                Console.WriteLine(d1);             // Tuesday 28 Feb 2012
                Console.WriteLine(d1.nextDay());   // Wednesday 29 Feb 2012
                Console.WriteLine(d1.nextDay());   // Thursday 1 Mar 2012
                Console.WriteLine(d1.nextMonth()); // Sunday 1 Apr 2012
                Console.WriteLine(d1.nextYear());  // Monday 1 Apr 2013

                MyDate d2 = new MyDate(2012, 1, 2);
                Console.WriteLine(d2);                 // Monday 2 Jan 2012
                Console.WriteLine(d2.previousDay());   // Sunday 1 Jan 2012
                Console.WriteLine(d2.previousDay());   // Saturday 31 Dec 2011
                Console.WriteLine(d2.previousMonth()); // Wednesday 30 Nov 2011
                Console.WriteLine(d2.previousYear());  // Tuesday 30 Nov 2010

                MyDate d3 = new MyDate(2012, 2, 29);
                Console.WriteLine(d3.previousYear());  // Monday 28 Feb 2011  
                MyDate d4 = new MyDate(2099, 11, 31); // Invalid year, month, or day!
                MyDate d5 = new MyDate(2011, 2, 29);  // Invalid year, month, or day!
                Console.WriteLine(d4);
                Console.WriteLine(d5);
                Console.WriteLine(getDayOfWeek(2099, 10, 31));
                Console.WriteLine(isValidDate(2099, 10, 32));
            }
}