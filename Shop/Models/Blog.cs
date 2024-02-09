namespace Shop.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }

        public bool enablsize { get; set; }
        public BlogType type { get; set; }

    }
}
