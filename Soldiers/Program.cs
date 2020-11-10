using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soldiers
{
    // Component 
    class Unit
    {
        public virtual int getStrength()
        {
            return 0;
        }
        public virtual void addUnit(Unit p)
        {
            
        }
    };

    // Primitives
    class Archer : Unit
    {
        public override int getStrength()
        {
            return 1;
        }
    };

    class Infantryman : Unit
    {
        public override int getStrength()
        {
            return 1;
        }
    };

    class Horseman : Unit
    {
        public override int getStrength()
        {
            return 1;
        }
    };


    // Composite
    class Army : Unit
    {
        public override int getStrength()
        {
            int total = 0;
            for (int i = 0; i < legion.Count(); i++)
                total += legion[i].getStrength();
            return total;
        }
        public override void addUnit(Unit p)
        {
            legion.Add(p);
        }
        private List<Unit> legion = new List<Unit>();
    };
 
class Program
    {
        static void Main(string[] args)
        {
            Army army = new Army();
            Archer archer = new Archer();
            Infantryman infantryman = new Infantryman();
            Horseman horseman = new Horseman();
            for (int i = 0; i < 3000; ++i)
                army.addUnit(infantryman);
            Console.WriteLine(army.getStrength());
            for (int i = 0; i < 1200; ++i)
                army.addUnit(archer);
            Console.WriteLine(army.getStrength());
            for (int i = 0; i < 300; ++i)
                army.addUnit(horseman);
            Console.WriteLine(army.getStrength());
            Console.ReadKey();
        }
    }
}
