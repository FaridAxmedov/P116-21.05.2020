using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    partial class Group
    {
        public override string ToString()
        {
            return $"{Id} {GroupName}";
        }

        public void AddStudent(Student newStu)
        {
            if (MaxStuCount == studentArr.Length)
            {
                Console.WriteLine($"{GroupName} qrupu Doludur.{newStu}-i bura elave ede bilmersiz!!!");
                return;
            }

            Array.Resize(ref studentArr, studentArr.Length + 1);
            studentArr[studentArr.Length - 1] = newStu;
            //Console.WriteLine($"{newStu.ToString()} elave olundu");
        }

        public void StudentList()
        {
            Console.WriteLine($"Gruop {GroupName}:");
            foreach (Student stu in studentArr)
            {
                Console.WriteLine(stu);
            }
        }
    }
}
