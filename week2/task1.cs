using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    public class Student
    {
        public string Name;
        public float EcatMarks;
        public float FscMarks;
        public float MatricMarks;
        public float Aggregate;
        public Student() { }
        public Student(Student student)
        {
            Name = student.Name;
            EcatMarks = student.EcatMarks;
            FscMarks = student.FscMarks;
            MatricMarks = student.MatricMarks;
            Aggregate = student.Aggregate;
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Ali";
            s1.EcatMarks = 300;
            s1.MatricMarks = 800;
            s1.FscMarks = 980;
            Student s2 = new Student(s1);
            s2.Name = "Sarmad";
            Console.WriteLine(s2.Name);
            Console.WriteLine(s1.Name);
        }
    }
}
