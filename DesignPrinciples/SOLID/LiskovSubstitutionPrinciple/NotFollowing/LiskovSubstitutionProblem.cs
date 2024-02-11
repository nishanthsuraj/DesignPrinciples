namespace DesignPrinciples.SOLID.LiskovSubstitutionPrinciple.NotFollowing
{
    internal class LiskovSubstitutionProblem
    {
        // Not following LSP
        public class Bird
        {
            public virtual void Fly()
            {
                // Flying logic
            }
        }

        public class Eagle : Bird
        {
            public override void Fly()
            {
                Console.WriteLine("Eagle Flys");
            }
        }

        public class Ostrich : Bird
        {
            public override void Fly()
            {
                // Ostriches can't fly, so this method is useless or misleading
                throw new NotImplementedException();
            }
        }
    }
}
