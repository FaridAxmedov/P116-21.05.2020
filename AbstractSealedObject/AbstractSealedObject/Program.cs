using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedObject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object,Partial,Sealed
            //int a = 5;
            //string word = "test";
            //Human h1 = new Human("Tural","Mehdiyev");
            //Human h2 = new Human("Elgun","Quluzade");

            //Person p1 = new Person();

            //Console.WriteLine(h1.ToString());
            //Console.WriteLine(h2.ToString());
            #endregion

            #region Abstract - class,method,property
            //Abstract method must be only in abstract class,not contains body,must be override in inheretance non-abstract class
            //From Abstract class cannot get instance
            Eagle eagle = new Eagle("shahin");
            eagle.Run();
            eagle.Eat();
            eagle.Fly();
            #endregion
        }
    }
}
