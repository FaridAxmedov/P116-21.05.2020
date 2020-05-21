using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    partial class Group
    {
        public string GroupName { get; set; }
        public int MaxStuCount { get; set; }

        public Student[] studentArr=new Student[0];

        private static int _id = 0;

        public readonly int Id;

        public Group()
        {
            Id = _id;
            _id++;
        }

        public Group(string groupName,int maxStuCount):this()
        {
            GroupName = groupName;
            MaxStuCount = maxStuCount;
        }
    }
}
