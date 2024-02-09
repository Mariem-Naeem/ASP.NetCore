namespace Shop.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public float Price { get; set; }

        public  int Quantity  { get; set; }

        public bool enablsize { get; set; }
        public Company company { get; set; }

    }
}
