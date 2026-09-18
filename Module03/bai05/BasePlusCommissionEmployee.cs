namespace Module03.bai05
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        public double BaseSalary { get; set; } 

        public BasePlusCommissionEmployee(string firstName, string lastName, string ssn, double grossSales, double commissionRate, double baseSalary)
            : base(firstName, lastName, ssn, grossSales, commissionRate)
        {
            BaseSalary = baseSalary;
        }

        public override double Earnings()
        {
            return base.Earnings() + BaseSalary;
        }

        public override string ToString()
        {
            return $"base salaried commission employee: {FirstName} {LastName}\nsocial security number: {SSN}\ngross sales: {GrossSales:N0}; commission rate: {CommissionRate};\nbase salary: {BaseSalary:N0}";
        }
    }
}