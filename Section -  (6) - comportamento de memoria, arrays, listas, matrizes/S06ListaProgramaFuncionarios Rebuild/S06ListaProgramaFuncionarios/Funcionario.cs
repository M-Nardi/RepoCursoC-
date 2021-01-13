using System;
using System.Collections.Generic;
using System.Text;


namespace S06ListaProgramaFuncionarios
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public double Salary { get; set; }

   
        public void IncreaseSalary (double percentage)
        {
            Salary = Salary * (1 + (percentage / 100));
        }

        public override string ToString()
        {
            return
                Id + ", " +
                Name + ", F$" +
                Salary.ToString("F2");
        }
    }


}
