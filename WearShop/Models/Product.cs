namespace WearShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Off { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ImageName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> comments { get; set; }
    }
}
