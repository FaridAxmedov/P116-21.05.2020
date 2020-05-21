using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSealedObject
{
    abstract class Animal
    {
        protected int _myProperty;
        //public abstract int Count;
        public abstract int MyProperty { get; set; }
        public abstract void Eat();

        public Animal(string test)
        {

        }

        public virtual void Run()
        {
            Console.WriteLine("Can run");
        }
    }

    abstract class Bird:Animal
    {
        public Bird(string test):base(test)
        {

        }
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public Eagle(string sort):base(sort)
        {

        }
        public override int MyProperty { get { return 5; } set { } }

        //public abstract void Test();
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle"); ;
        }

        public override void Run()
        {
            Console.WriteLine("Eagle cannot run");
        }
    }
}
