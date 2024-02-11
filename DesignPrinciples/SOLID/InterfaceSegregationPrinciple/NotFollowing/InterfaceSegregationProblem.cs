namespace DesignPrinciples.SOLID.InterfaceSegregationPrinciple.NotFollowing
{
    internal class InterfaceSegregationProblem
    {
        public interface IAnimal
        {
            void Walk();
            void Swim();
            void Fly();
        }
        public class Duck : IAnimal
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
        public class Cat : IAnimal
        {
            public void Walk()
            {
                Console.WriteLine("Cat is walking.");
            }
            public void Swim()
            {
                throw new NotImplementedException("Cats usually don't swim.");
            }
            public void Fly()
            {
                throw new NotImplementedException("Cats can't fly.");
            }
        }
    }
}
