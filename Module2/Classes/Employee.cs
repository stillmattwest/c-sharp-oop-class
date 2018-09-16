abstract class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    public int EmployeeID { get; set; }

     static int ID { get; set; } = 0;

    public Employee(string n, double bs)
    {
        Name = n;
        BaseSalary = bs;
        EmployeeID = ++ID;
    }   

    public double getBaseSalary()
    {
        return BaseSalary;
    }

    public string getName()
    {
        return Name;
    }

    public int getEmployeeID()
    {
        return EmployeeID;
    }

    public string toString(){
        return $"{EmployeeID} {Name}";
    }

    public abstract string employeeStatus();
}