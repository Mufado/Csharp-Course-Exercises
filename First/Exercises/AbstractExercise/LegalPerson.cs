namespace First.Exercises.AbstractExercise
{
    class LegalPerson : Person
    {
        public int EmployeeQuantity { get; set; }

        public LegalPerson(string name, double annualIncome, int employeeQuantity)
            : base(name, annualIncome)
        {
            EmployeeQuantity = employeeQuantity;
        }

        public override double Tax()
        {
            return EmployeeQuantity > 10 ? AnnualIncome * 0.14 : AnnualIncome * 0.16;
        }
    }
}
