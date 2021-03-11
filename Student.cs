
using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetProject
{
     struct Student
    {
        public string Name;
        public string ClassAndSection;
        public string GetName()
        {
            return Name;
        }
        public string GetClassAndSection()
        {
            return ClassAndSection;
        }
    }
    static class StudentClass
    {
        private static List<Student> students = new List<Student>();
        public static void AddStudent()
        {
            Console.WriteLine("Enter Name Of The Student");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Class And Section");
            string cls = Console.ReadLine();
            Student s = new Student();
            s.Name = name;
            s.ClassAndSection = cls;
            students.Add(s);
        }

        public static List<Student> GetStudentList()
        {
            return students;
        }
    }

}

