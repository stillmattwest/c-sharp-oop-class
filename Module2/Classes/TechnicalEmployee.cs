class TechnicalEmployee : Employee
{
    public TechnicalEmployee(string n) : base(n, 75000)
    {

    }

    public override string employeeStatus()
    {
        return $"{EmployeeID} {Name} has 10 successful check ins";
    }
}