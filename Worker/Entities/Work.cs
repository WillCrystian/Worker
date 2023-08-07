using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Entities.Enums;

namespace Worker.Entities
{
    internal class Work
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departaments Departament { get; set; }
        public List<HourContracts> Contracts { get; set; } = new List<HourContracts>();

        public Work() { }

        public Work(string name, WorkerLevel level, double baseSalary, Departaments departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContracts contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContracts contracts)
        {
            Contracts.Remove(contracts);
        }

        public double Income( int year, int month)
        {
            double sum = BaseSalary;

            foreach(HourContracts contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }

            return sum;
        }
    }
}
