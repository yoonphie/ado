using System;
using System.Collections.Generic;

namespace task22
{
    class Program
    {
        static void Main(string[] args)
        {
            ff file = new ff();

            Console.WriteLine("Task 1:");

            List<Student> ar = file.inputStudents("students.txt");
            foreach (Student item in ar)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("");

            Console.WriteLine("Task 2:");

            List<Book> r1 = file.inputBooks("books.txt");
            foreach (Book item in r1)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("");


        }
    }
}
