using PetManagement.Models;

public class Appointment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public int PetId { get; set; }
    public Pet Pet { get; set; }
}
