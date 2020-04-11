using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("ade", 27);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("reza", 36, "190302", "Math");
            teacher.GetNameAndAge();

            Students students = new Students("yanti", 19, "10506", "yanti.1203@students.amikom.ac.id");
            students.GetNameAndAge();

            Console.ReadKey();
        }
    }
}