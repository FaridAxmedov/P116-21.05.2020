using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private static int _id = 0;

        public readonly int Id;

        public Student()
        {
            Id = _id;
            _id++;
        }

        public Student(string name,string surname):this()
        {
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname}";
        }
    }
}
