using System;
using System.Globalization;
using projetoInterface.Entities;
using projetoInterface.Services;

namespace projetoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Contract value: ");
            double totaltValue = double.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totaltValue);

            Console.WriteLine("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
