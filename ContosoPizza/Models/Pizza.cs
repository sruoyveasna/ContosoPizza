namespace ContosoPizza.Models
{
    public class Pizza
    {
        //PK column - unique identifier
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
        public string? Size { get; set; }
        public string? Description { get; set; }
        public bool IsGlutenFree { get; set; }
    }
}
