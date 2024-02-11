namespace DesignPrinciples.SOLID.SingleResponsibilityPrinciple.NotFollowing
{
    internal class SingleResponsibilityProblem
    {
        // Not following SRP
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }

            public void Save()
            {
                // Database logic
            }

            public void Print()
            {
                // Printing logic
            }
        }
    }
}
