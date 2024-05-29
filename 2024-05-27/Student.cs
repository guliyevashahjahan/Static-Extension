using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_27
{
    public class Student
    {
        private static int Count;
        public Student(string fullName, double point)
        {
            Count++;
            Id = Count;
            fullName = fullName;
            Point = point;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public double Point { get; set; }
        public static void ShowInfo(string fullname,double point)
        {
            Console.WriteLine($"Full Name: {fullname} \n Point: {point}");
        }
    }
}
