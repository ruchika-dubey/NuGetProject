using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetProject
{
    struct Subject
    {
        public string Name;
        public string SubjectCode;
        public string GetName()
        {
            return Name;
        }
        public string GetSubjectCode()
        {
            return SubjectCode;
        }
    }
    static class SubjectClass
    {
        private static List<Subject> subjects = new List<Subject>();
        public static void AddSubject()
        {
            Console.WriteLine("Enter Name Of The Subject");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Subject Code");
            string cls = Console.ReadLine();
            Subject s = new Subject();
            s.Name = name;
            s.SubjectCode = cls;
            subjects.Add(s);
        }
        public static List<Subject> GetSubjectList()
        {
            return subjects;
        }
    }
}
