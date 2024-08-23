public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public int DepartmentId { get; set; }
}

public class Evaluation
{
    public int Id { get; set; }
    public int ManagerId { get; set; }
    public int EmployeeId { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
}