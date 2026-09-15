using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone myPhone1 = new Samsung();
            myPhone1.turn();
            Smartphone myPhone2 = new Redmi();
            myPhone2.turn();
        }

    }
    internal class Smartphone
    {

        private String name;
        private int Age;
        public String owner;

        public virtual void turn()
        {
            Console.WriteLine("Smartphone turn");
        }
    }



    internal class Samsung : Smartphone
    {
        public override void turn()
        {
            Console.WriteLine("Samsung turn");
        }
    }



    internal class Redmi : Smartphone

    {
        public override void turn()
        {
            Console.WriteLine("redmi turn");
        }

    }



    internal abstract class program1
    {
        public abstract void action();
    }
}

