using RecursivePatternsSampleV70.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecursivePatternsSampleV70
{
    class Program
    {
        static void Main(string[] args)
        {
           
            foreach (var result in GetStudentIsPassedAndMale())
            {
                Console.WriteLine($"姓名 : {result.Name } : 分數 {result.Score }");
            }
        }


        static IEnumerable<(string Name, int Score)> GetStudentIsPassedAndMale()
        {
            var people = Create();

            return people.Where((x) => x is Student student 
                                && student.IsPassed == true 
                                && student.Gender == Gender.Male 
                                && student.Name != null).Select((y) =>
                                                         {
                                                             Student s = y as Student;
                                                             return (s.Name, s.Score);
                                                         });
        }

        static List<IPerson> Create()
        {
            return new List<IPerson>
            {
                new Teacher {Name= "Bill" },
                new Teacher {Name= "David"},
                new Student{ Name = "魯夫",  Gender = Gender.Male , Score= 60},
                new Student{ Name = "妮可羅賓",  Gender = Gender.Female , Score= 82},
                new Student{ Name = "娜美",   Gender = Gender.Female, Score= 70 },
                new Student{ Name = "騙人布" ,Gender = Gender.Male, Score= 55 },
                new Student{ Name = "香吉士",  Gender = Gender.Male, Score= 58 },
                new Student{ Name = "喬巴",   Gender = Gender.Male, Score= 67 },
                new Student{ Name = "布魯克",  Gender = Gender.Male, Score= 42 },
                new Student{ Name = "索隆",  Gender = Gender.Male, Score= 80 },
                new Student{ Gender = Gender.Male , Score= 60},
                new Student{ Name = string.Empty,  Gender = Gender.Male , Score= 99},
            };
        }
    }
}
