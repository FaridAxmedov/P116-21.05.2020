using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedObject
{
    //sealed classlar - hech bir classa miras oturmur
    sealed class Person:Human
    {
        public Person()
        {

        }

        public Person(string name, string surname) : base(name, surname)
        {

        }
    }
}
