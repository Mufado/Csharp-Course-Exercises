using System;
using System.Collections.Generic;
using System.Globalization;

namespace First.Exercises.AbstractExercise
{
    class AbstractExerciseProgram
    {
        public void AbstractExercise()
        {
            var payersList = new List<Person>();
            Console.Write("Enter the number of payers: ");
            int taxPayers_quantity = int.Parse(Console.ReadLine());

            for (int n = 1; n <= taxPayers_quantity; n++)
            {
                Console.WriteLine($"Tax payer #{n} data:");
                Console.Write("Individual or company (i/c)? ");
                char taxPayer_type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string taxPayer_name = Console.ReadLine();
                Console.Write("Annual income: ");
                double taxPayer_annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (taxPayer_type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double taxPayer_healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    payersList.Add(new IndividualPerson(taxPayer_name, taxPayer_annualIncome, taxPayer_healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int taxPayer_employeeQuantity = int.Parse(Console.ReadLine());
                    payersList.Add(new LegalPerson(taxPayer_name, taxPayer_annualIncome, taxPayer_employeeQuantity));
                }
            }

            double totalTaxes = 0;
            Console.WriteLine("\nTAXES PAID:");
            foreach (var payer in payersList)
            {
                Console.WriteLine(payer);
                totalTaxes += payer.Tax();
            }

            Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
