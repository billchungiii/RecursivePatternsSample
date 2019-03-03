using RecursivePatternsSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RecursivePatternsSample
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

        /// <summary>
        /// 同時還會檢查 Name 不是 null
        /// </summary>
        /// <returns></returns>
        static IEnumerable <(string Name, int Score)> GetStudentIsPassedAndMale()
        {
           
            var people = Create();
            foreach (var p in people)
            {
                if (p is Student { Gender: Gender.Male, IsPassed: true, Name: string name, Score: int score })
                {
                    yield return (name, score);
                }
            }         
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
