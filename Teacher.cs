using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetProject
{
    struct Teacher
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
    static class TeacherClass
    {
        private static List<Teacher> teachers = new List<Teacher>();
        public static void AddTeacher()
        {
            Console.WriteLine("Enter Name Of The Teacher");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Class And Section");
            string cls = Console.ReadLine();
            Teacher t = new Teacher();
            t.Name = name;
            t.ClassAndSection = cls;
            teachers.Add(t);
        }
        public static List<Teacher> GetTeacherList()
        {
            return teachers;
        }
    }
}
