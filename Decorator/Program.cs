using System;
namespace Decorator.Examples
{
    class MainApp
    {
        static void Main()
        {

            ConcreteChristmasTree cе = new ConcreteChristmasTree();
            GarlandDecorator g1 = new GarlandDecorator();
            OrnamentDecorator o1 = new OrnamentDecorator();
            OrnamentDecorator o2 = new OrnamentDecorator();
            OrnamentDecorator o3 = new OrnamentDecorator();

            // Link decorators
            g1.SetComponent(cе);
            o1.SetComponent(g1);
            o2.SetComponent(g1);
            o3.SetComponent(g1);

            o1.Operation();
            o2.Operation();
            o3.Operation();

            // Wait for user
            Console.Read();
        }
    }
    // "Component"
    abstract class ChristmasTree
    {
        public abstract void Operation();
    }


    // "ConcreteComponent"
    class ConcreteChristmasTree : ChristmasTree
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }

    // "Decorator"
    abstract class Decorator : ChristmasTree
    {
        protected ChristmasTree component;

        public void SetComponent(ChristmasTree component)
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


    // "ConcreteDecoratorB" 
    class GarlandDecorator : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddGarland();
        }
        void AddGarland()
        { Console.WriteLine("Гірлянда світиться на ялинці"); }
    }

    // "ConcreteDecoratorB" 
    class OrnamentDecorator : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddOrnament();
        }
        void AddOrnament()
        { Console.WriteLine("ялинка прикрашена"); }
    }
}
