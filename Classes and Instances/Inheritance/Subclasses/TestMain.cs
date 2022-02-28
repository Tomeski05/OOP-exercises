using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Subclasses
{
    class TestMain
    {
        public static void main(string[] args)
        {
            Student s1 = new Student("PRO192", 2021, 300, "Ha Gia Kinh", "Ha Noi");
            Console.WriteLine(s1);
            s1.setAddress("Quang Binh");
            Console.WriteLine(s1);
            s1.setFee(300);
            s1.setProgram("MAD101");
            s1.setYear(2022);
            Console.WriteLine("Name is " + s1.getName());
            Console.WriteLine("Adress is " + s1.getAddress());
            Console.WriteLine("Fee is " + s1.getFee());
            Console.WriteLine("Program is " + s1.getProgram());
            Console.WriteLine("Year is " + s1.getYear());

            Stuff sf1 = new Stuff("Dieu Linh", "Viet Nam", "Ba Vi", 250);
            Console.WriteLine(sf1);

            sf1.setAddress("Japan");
            Console.WriteLine(sf1);
            sf1.setPay(300);
            sf1.setSchool("Tokyo Universe");
            Console.WriteLine("Name is " + sf1.getName());
            Console.WriteLine("Adress is " + sf1.getAddress());
            Console.WriteLine("Pay is " + sf1.getPay());
            Console.WriteLine("School is " + sf1.getSchool());
        }
    }
}
