namespace First.Exercises.AbstractExercise
{
    class IndividualPerson : Person
    {
        public double HealthExpenditures { get; set; }

        public IndividualPerson(string name) : base(name)
        {
        }
        public IndividualPerson(string name, double annualIncome, double healthCareSpending)
            : base(name, annualIncome)
        {
            HealthExpenditures = healthCareSpending;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000)
                return (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
            else
                return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
        }
    }
}
