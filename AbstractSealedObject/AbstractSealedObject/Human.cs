using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedObject
{
    //partial class - class-i hisselere ayirmaq uchundur,amma eyni class sayilir.
    partial class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Human()
        {

        }
        public Human(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
