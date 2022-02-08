namespace First.Exercises.ListExercise
{
    class Employee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public double Salary
        {
            get { return Salary; }
            private set
            {
                if (value >= 0)
                    Salary = value;
            }
        }
    }
}
