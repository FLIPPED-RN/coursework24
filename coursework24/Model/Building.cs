namespace coursework24.Model;

public class Building
{
    public int BuildingId { get; set; }
    public string Name { get; set; }
    public ICollection<Room> Rooms { get; set; }
}