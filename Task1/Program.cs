using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public Student[] Students { get; set; }


        public class Student
        {
            public string Name { get; set; }

            public string city { get; set; }


            static void Main(string[] args)
            {
                Student[] stud1 = new Student[]
                 {
                new Student() { Name= "rohan", city="pune"},
                new Student() { Name= "suraj", city="mumbai"},
                new Student() { Name= "kishor", city="nagpur"},
                 };
                Student[] stud2 = new Student[]
                     {
                new Student() { Name = "parth", city = "landon" },
                new Student() { Name = "amol", city = "france" },
                     };

                Student[] stud3 = new Student[]
                     {
                new Student() { Name = "nilesh", city = "pune" },
                new Student() { Name = "rahul", city = "mumbai" },
                     };


                Course[] courses =
                {
            new Course() { Id = 1, Name = "C#", Fees = 25000,Students=stud1},
            new Course() { Id = 2, Name = "Java", Fees = 25000,Students=stud2},
            new Course() { Id = 3, Name = "MVC", Fees = 40000,Students=stud3},
                };
                foreach (Course c in courses)
                {
                    Console.WriteLine($"{c.Id} {c.Name} {c.Fees}");
                    foreach (Student s in c.Students)
                    {
                        Console.WriteLine($"\t{s.Name}->{s.city}");
                    }
                }



            }
        }
    }
}
