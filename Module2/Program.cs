using System;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lynne = new TechnicalEmployee ("Lynne West");
            var logan = new TechnicalEmployee("Logan West");
            var riley = new BusinessEmployee("Riley West");
            Console.WriteLine(lynne.employeeStatus());
            Console.WriteLine(logan.employeeStatus());
            Console.WriteLine(riley.employeeStatus());
        }
    }
}
