namespace ProductApplication.Models.Entities
{
    public class Product
    {

        public int Id { get; set; } // Auto-incremented by the database
        public string Name { get; set; } 
        public decimal Price { get; set; }
        public int Stock { get; set; }



    }
}
