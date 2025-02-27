namespace PetManagement.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }

}
