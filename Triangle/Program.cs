using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle prototype = new Triangle(2, 2, 2);
            Prototype clone = prototype.Clone();
            clone = prototype.Clone();
            Console.WriteLine("Периметр трикутника = " + prototype.Perim());
            Console.WriteLine("Площа трикутника = " + prototype.Square());
            Console.ReadKey();
        }
    }
    abstract class Prototype
    {
        public int Id { get; private set; }
        public List<double> Vershines { get; set; }
        public Prototype(int id)
        {
            this.Id = id;
            Vershines = new List<double>(id);
        }
        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(int id)
        : base(id)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id)
        : base(id)
        { }
        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }

    class Triangle : Prototype
    {
        public Triangle(int id)
        : base(id)
        { }
        public Triangle(int f, int s, int t)
        : base(3)
        {
            Vershines = new List<double>() { f, s, t };
        }
        public double Perim()
        {
            return Vershines[0] + Vershines[1] + Vershines[2];
        }
        public double Square ()
        {
            double p = Perim() / 2.0 ;
            return Math.Sqrt(p * (p - Vershines[0]) * (p - Vershines[1]) * (p - Vershines[2]));
        }
        public override Prototype Clone()
        {
            return new Triangle(Id);
        }
    }
}