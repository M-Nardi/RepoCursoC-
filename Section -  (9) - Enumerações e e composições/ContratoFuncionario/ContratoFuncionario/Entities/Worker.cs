using ContratoFuncionario.Entities.Enums;
using System.Collections.Generic;

namespace ContratoFuncionario.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        
        
        public Worker() 
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }


    }
}
