using System;
using System.Collections.Generic;
using System.Text;

namespace RecursivePatternsSample.Models
{
    interface IPerson
    {
         Guid ID { get; set; }

         string Name { get; set; }
    }

    class Teacher : IPerson
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public string Subject { get; set; }
    }

    class Student : IPerson
    {
        public Guid ID { get; set; }
        public string Name { get; set; }

        public bool IsPassed
        {
            get { return Score > 59; }
        }

        public Gender Gender { get; set; }

        public int Score { get; set; }

    }

    public enum Gender
    {
        Male, Female
    }
}
