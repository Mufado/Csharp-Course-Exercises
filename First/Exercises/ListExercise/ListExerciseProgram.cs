using System;
using System.Collections.Generic;
using System.Globalization;

namespace First.Exercises.ListExercise
{
    public class ListExerciseProgram
    {
        public void ListExercise()
        {
            Console.Write("How many employees will be registered?");
            int numberOfEmployeesToRegister = int.Parse(Console.ReadLine());

            var employeers = new List<Employee>();

            for (var counter = 1; counter <= numberOfEmployeesToRegister; counter++)
            {
                Console.WriteLine($"\nEmployee #{counter}");

                Console.WriteLine("Id: ");
                int IdEmployeer = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string NameEmployeer = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double SalaryEmployeer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employeers.Add(new Employee(IdEmployeer, NameEmployeer, SalaryEmployeer));
            }
        }
    }
}
