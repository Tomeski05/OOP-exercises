using System;
using System.Collections.Generic;
using System.Text;

namespace More_Exercises_on_Classes.BigInteger
{
    public class TestBigInteger
    {
        public static void main(string[] args)
        {
            TestBigInteger i1 = new TestBigInteger("11111111111111111111111111111111111111111111111111111111111111");
            TestBigInteger i2 = new TestBigInteger("2222222222222343242222222234234234234212222222222222222222");
            Console.WriteLine($"{i1} + {i2}");
        }
    }
}
