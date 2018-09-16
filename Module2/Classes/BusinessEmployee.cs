class BusinessEmployee : Employee
{
    public BusinessEmployee(string n) : base(n, 50000)
    {

    }

    public override string employeeStatus()
    {
        return $"{EmployeeID} {Name} with a budget of 22500.0";
    }

}