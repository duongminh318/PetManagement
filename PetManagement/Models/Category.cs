using PetManagement.Models;

public class Category
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public List<Pet> Pets { get; set; }
}
