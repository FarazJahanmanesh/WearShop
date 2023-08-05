namespace WearShop.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public string Titel { get; set; }
		public string Description { get; set; }
		public string Email { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreatedDate { get; set; }
		public int ProductId { get; set; }
		public Product product { get; set; }
    }
}
