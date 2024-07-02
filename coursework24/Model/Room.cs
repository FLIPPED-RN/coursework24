namespace coursework24.Model;

public class Room
{
    public int RoomId { get; set; }
    public int BuildingId { get; set; }
    public string RoomNumber { get; set; }
    public string Location { get; set; }
    public double Width { get; set; }
    public double Length { get; set; }
    public double Height { get; set; }
    public string Purpose { get; set; }
    public string RoomType { get; set; }
    public int DepartmentId { get; set; }
    public Building Building { get; set; }
    public Department Department { get; set; }
}