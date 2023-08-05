using Microsoft.EntityFrameworkCore;
using WearShop.Contracts;
using WearShop.Models;

namespace WearShop.Repository
{
    public class CommentRepository: ICommentRepository
    {
        private readonly WearShopDbContext _context;
        public CommentRepository(WearShopDbContext context)
        {
            _context = context;
        }
        public async Task<List<Comment>> ShowAllComments(int id)
        {
            return await _context.Comments.AsNoTracking().Where(c =>c.IsActive== true &&c.ProductId == id).ToListAsync();
        }
        public async Task AddComment(Comment comment)
        {
            await _context.Comments.AddAsync(new Comment
            {
                Id = comment.Id,
                CreatedDate = DateTime.Now,
                Email = comment.Email,
                Description = comment.Description,
                IsActive = comment.IsActive,
                product = comment.product,
                ProductId = comment.ProductId,
                Titel = comment.Titel,
            });
            _context.SaveChanges();
        }
    }
}
