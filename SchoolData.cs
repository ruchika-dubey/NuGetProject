using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetProject
{
    class SchoolData
    {
        public static void Do()
        {
            string UserChoice;
            Console.WriteLine("*****Welcome To Rainbow School Storing System*****");
            do
            {
                Console.WriteLine("*****Choose A Option To Continue*****");
                Console.WriteLine("1. Add Data Of a Student");
                Console.WriteLine("2. Add Data Of a Teacher");
                Console.WriteLine("3. Add Data Of a Subject");
                Console.WriteLine("4. Diplay Students Data");
                Console.WriteLine("5. Diplay Teachers Data");
                Console.WriteLine("6. Diplay Subjects Data");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("*****Adding Data of a Student*****");
                        StudentClass.AddStudent();
                        break;
                    case 2:
                        Console.WriteLine("*****Adding Data of a Teacher*****");
                        TeacherClass.AddTeacher();
                        break;
                    case 3:
                        Console.WriteLine("*****Adding Data of a Subject*****");
                        SubjectClass.AddSubject();
                        break;
                    case 4:
                        Console.WriteLine("*****Students List*****");
                        List<Student> studs = StudentClass.GetStudentList();
                        if (studs.Count == 0)
                            Console.WriteLine("No Student Data To Display ");
                        else
                            foreach (Student s in studs)
                                Console.WriteLine("Name: " + s.GetName() + "\t Class And Section: " + s.GetClassAndSection());
                        break;
                    case 5:
                        Console.WriteLine("*****Teachers List*****");
                        List<Teacher> teachs = TeacherClass.GetTeacherList();
                        if (teachs.Count == 0)
                            Console.WriteLine("No Teacher Data To Display");
                        else
                            foreach (Teacher s in teachs)
                                Console.WriteLine("Name: " + s.GetName() + "\t Class And Section: " + s.GetClassAndSection());
                        break;
                    case 6:
                        Console.WriteLine("*****Subjects List*****");
                        List<Subject> subjs = SubjectClass.GetSubjectList();
                        if (subjs.Count == 0)
                            Console.WriteLine("No Subject Data To Display");
                        else
                            foreach (Subject s in subjs)
                                Console.WriteLine("Subject Name: " + s.GetName() + "\t Subject Code: " + s.GetSubjectCode());
                        break;
                    default:
                        Console.WriteLine("Incorrect Choice");
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Want to continue?(Type yes/no)");
                UserChoice = Console.ReadLine().ToLower();


            } while (UserChoice.Equals("yes"));
        }

    }
}
