namespace coursework24.Model;

public class Department
{
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public int? ParentDepartmentId { get; set; }
    public Department ParentDepartment { get; set; }
    public ICollection<Department> SubDepartments { get; set; }
}
