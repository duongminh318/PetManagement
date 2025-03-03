using PetManagement.Models;

public class Owner
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public List<Pet>? Pets { get; set; }
}
