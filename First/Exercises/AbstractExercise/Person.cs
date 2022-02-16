using System.Globalization;

namespace First.Exercises.AbstractExercise
{
    abstract class Person
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        protected Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return $"{Name}: $ {Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
