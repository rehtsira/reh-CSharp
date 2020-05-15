using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Fruit
    {
        public string type;
        public Fruit(string s)
        {
            Console.WriteLine("Fruit: " + s);
            type = s;
        }
        public virtual void BeingEaten()
        {
            Console.WriteLine("Fruit is getting munched on");
        }
    }

    public class Apple : Fruit
    {
        public Apple(string initialName) : base(initialName)
        {
            Console.WriteLine("Apple: " + initialName);
            this.type = initialName;
        }
        public override void BeingEaten()
        {
            Console.WriteLine("Apple is getting munched on");
            base.BeingEaten();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Apple c = new Apple("Golden Apple");
            Console.WriteLine(c.type);
            c.BeingEaten();
            Console.ReadLine();
        }
    }
}
