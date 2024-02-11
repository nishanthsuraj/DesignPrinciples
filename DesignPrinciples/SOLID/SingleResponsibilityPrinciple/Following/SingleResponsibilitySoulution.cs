namespace DesignPrinciples.SOLID.SingleResponsibilityPrinciple.Following
{
    internal class SingleResponsibilitySoulution
    {
        // Following SRP
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        public class EmployeeRepository
        {
            public void Save(Employee employee)
            {
                // Database logic
            }
        }

        public class EmployeePrinter
        {
            public void Print(Employee employee)
            {
                // Printing logic
            }
        }
    }
}
