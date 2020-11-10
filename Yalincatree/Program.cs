using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {
            // Create ConcreteComponent and two Decorators
            Star cS = new Star();
            Bead cB = new Bead();
            Garland cG = new Garland();
            New_Year_Tree d1 = new New_Year_Tree();

            // Link decorators
            d1.SetComponent(cS);
            d1.SetComponent(cB);
            d1.SetComponent(cS);
            d1.SetComponent(cG);

            d1.Operation();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class Component
    {
        public abstract void Operation();
    }

    // "ConcreteComponent"
    class Star : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Tree is decorated by the Star");
        }
    }
    // "ConcreteComponent"
    class Bead : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Tree is decorated by the Bead");
        }
    }
    // "ConcreteComponent"
    class Garland : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Tree is decorated by the Garland");
        }
    }
    // "Decorator"
    abstract class Decorator : Component
    {
        protected Component component;

        public virtual void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }

    // "ConcreteDecorator"
    class New_Year_Tree : Decorator
    {
        private Star componentS = new Star();
        private Bead componentB = new Bead();
        private Garland componentG = new Garland();
        private string addedState = "";

        public override void SetComponent(Component component)
        {
            if (component.GetType() == componentS.GetType())
                addedState += "Star ";
            else if (component.GetType() == componentB.GetType())
                addedState += "Bead ";
            else
                addedState += "Garland ";
            component.Operation();
        }
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("All toys on the tree: " + addedState);
        }
    }

    //// "ConcreteDecoratorB" 
    //class ConcreteDecoratorB : Decorator
    //{
    //    public override void Operation()
    //    {
    //        base.Operation();
    //        AddedBehavior();
    //        Console.WriteLine("ConcreteDecoratorB.Operation()");
    //    }
    //    void AddedBehavior()
    //    { }
    //}
}