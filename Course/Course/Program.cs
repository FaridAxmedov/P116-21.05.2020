using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("Hesen", "Hesenli");
            Student stu1 = new Student("Ulvi", "Mecidov");
            Student stu2 = new Student("Elgun", "Guluzade");
            Student stu3 = new Student("Hesen", "Hesenbeyli");
            Student stu4 = new Student("Tural", "Mehdiyev");
            Student stu5 = new Student("Zaur", "Ferruxzade");

            Group group1 = new Group("P116", 2);
            Group group2 = new Group("P314", 3);

            group1.AddStudent(stu);
            group1.AddStudent(stu1);
            //group1.StudentList();

            group2.AddStudent(stu2);
            group2.AddStudent(stu3);
            group2.AddStudent(stu4);
            //group2.AddStudent(stu5);
            
            group2.StudentList();

        }
    }
}
