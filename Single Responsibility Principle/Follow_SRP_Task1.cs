public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
}

class EmployeeSalary
{
    public decimal CalculateYearlySalary(Employee employee)
    {
        return employee.Salary * 12;
    }
}

class EmployeeReport
{
    public decimal GenerateReport(Employee employee, string reportType)
    {
        // Code to generate report based on reportType
    }
}

class EmployeeNotification
{
    public void SendNotification(Employee employee, string recipient, string message)
    {
        // Code to send email notification
    }
}
