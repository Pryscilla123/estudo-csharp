using System.Security.Cryptography.X509Certificates;
using composicao.Entities.Enums;

namespace composicao.Entities;

class Worker
{
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }
    public Department Department { get; set; }
    public List<HourContract> Contratcs { get; set; } = new List<HourContract>();

    public Worker ()
    {
    }

    public Worker (string name, WorkerLevel level, double baseSalary, Department department)
    {
        Name = name;
        Level = level;
        Department = department;
        BaseSalary = baseSalary;
    }

    public void AddContract(HourContract contract)
    {
        Contratcs.Add(contract);
    }

    public void RemoveContract(HourContract contract)
    {
        Contratcs.Remove(contract);
    }

    public double Income(int year, int month){
        //where to find and select what to get the especific item
        var monthIncome = Contratcs.Where(x => x.Date.Year == year && x.Date.Month == month).Select(x => x.TotalValue()).ToList();
        return BaseSalary + monthIncome.Sum();
    }
}