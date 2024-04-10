using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ali = new Student();
            Console.WriteLine(ali.Age1);

            Student murad = new Student();
            Console.WriteLine(murad.Age1);

            Student gadir = new Student();
            Console.WriteLine(gadir.Age1);

            Student nicat = new Student();
            Console.WriteLine(nicat.Age1);
        }

        public class Student
        {
            private static int Age = 0;
            public int Age1 { get; set; }

            public Student()
            {
                Age1 = ++Age;
            }
        }
    }
}
