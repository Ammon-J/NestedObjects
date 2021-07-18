using System;
using System.Collections.Generic;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currInst = new Instructor()
            {
                FullName = "Homer Simpson",
                Email = "Homer.Simpson@cptc.edu",
            };

            Student s1 = new Student()
            {
                FirstName = "Jim",
                LastName = "Halpert",

            };

            Student s2 = new Student()
            {
                FirstName = "Creed",
                LastName = "Bratton",

            };

            Student s3 = new Student()
            {
                FirstName = "Kelly",
                LastName = "Kapur",

            };

            Course test = new Course();
            test.Title = "CPW 212 - Adv .NET";
            test.Description = "More .NET than what you already learned";
            test.Credits = 5;
            test.CourseInstructor = currInst;
            test.Roster = new List<Student>();

            // Adding students to course
            test.Roster.Add(s1);
            test.Roster.Add(s2);
            test.Roster.Add(s3);

            Console.WriteLine(test.Title);
            Console.WriteLine("Is taught by " + test.CourseInstructor.FullName);
            Console.WriteLine("Credits: " + test.Credits);
            Console.WriteLine("Currently Enrolled Students: ");

            foreach(Student s in test.Roster)
            {
                Console.WriteLine(s.FirstName + ", " + s.LastName);
            }
            Console.ReadKey();
        }
    }
}
