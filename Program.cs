using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceup
{
    class Student
    {
        public string Name { get; set; }
        public int Course { get; set; }
        public bool Gender { get; set; }

        public Student(string name, int course, bool gender)
        {
            Name = name;
            Course = course;
            Gender = gender;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student stasik = new Student("Стасик", 3, false);
        }
    }
}
