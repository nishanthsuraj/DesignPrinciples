namespace DesignPrinciples.SOLID.InterfaceSegrigationPrinciple.Following
{
    internal class InterfaceSegregationSolution
    {
        public interface IWalker
        {
            void Walk();
        }
        public interface ISwimmer
        {
            void Swim();
        }
        public interface IFlyer
        {
            void Fly();
        }
        public class Duck : IWalker, ISwimmer, IFlyer
        {
            public void Walk()
            {
                Console.WriteLine("Duck is walking.");
            }
            public void Swim()
            {
                Console.WriteLine("Duck is swimming.");
            }
            public void Fly()
            {
                Console.WriteLine("Duck is flying.");
            }
        }
        public class Cat : IWalker
        {
            public void Walk()
            {
                Console.WriteLine("Cat is walking.");
            }
        }

        //Testing the Interface Segregation Principle
        public class Program
        {
            public static void Main()
            {
                Duck duck = new Duck();
                duck.Walk();
                duck.Swim();
                duck.Fly();
                Cat cat = new Cat();
                cat.Walk();
                //cat.Swim(); //Compile Time Error
                //cat.Fly();  //Compile Time Error
                Console.ReadKey();
            }
        }
    }
}
