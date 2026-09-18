using System;

namespace Module03.bai05
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }

        public Employee(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
        }

        public abstract double Earnings();

        public override string ToString()
        {
            return $"{FirstName} {LastName}\nsocial security number: {SSN}"; 
        }
    }
}