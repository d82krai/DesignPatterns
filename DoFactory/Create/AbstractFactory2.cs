using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.Create
{
    class AbstractFactory2
    {
        static void Main()
        {

        }
    }



    public abstract class Animal
    {
        public abstract string Speak();
    }

    public class Dog : Animal
    {

        public override string Speak()
        {
            return "Bho Bho!!!";
        }
    }

    public class Cat : Animal
    {

        public override string Speak()
        {
            return "Myaaoo Myaaoo!!!";
        }
    }
}
