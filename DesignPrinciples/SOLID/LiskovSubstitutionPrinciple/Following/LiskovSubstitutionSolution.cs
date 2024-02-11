namespace DesignPrinciples.SOLID.LiskovSubstitutionPrinciple.Following
{
    internal class LiskovSubstitutionSolution
    {
        // Following LSP
        public abstract class Bird
        {
            public abstract void Move();
        }

        public class FlyingBird : Bird
        {
            public override void Move()
            {
                // Flying logic
            }
        }

        public class NonFlyingBird : Bird
        {
            public override void Move()
            {
                // Walking logic
            }
        }

        public class Ostrich : NonFlyingBird
        {
            // No need to override Move method
        }

        public class Eagle : FlyingBird
        {
            // No need to override Move method
        }
    }
}
