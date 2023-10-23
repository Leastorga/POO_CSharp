using System.Diagnostics.Contracts;
using System.Dynamic;
using Exec01.Entities.Enums;

namespace Exec01.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> contracts = new List<HourContract>();

        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }


        public void AddContracts(HourContract contract)
        {
            contracts.Add(contract);
        }

        public void RemoveContracts(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in contracts) // Para cada contrato dentro da lista de contratos
            {
                if (contract.Date.Year == year || contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
