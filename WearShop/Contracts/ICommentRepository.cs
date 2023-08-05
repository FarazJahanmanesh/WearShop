using WearShop.Models;

namespace WearShop.Contracts
{
    public interface ICommentRepository
    {
        public Task<List<Comment>> ShowAllComments(int id);
        public Task AddComment(Comment comment);
    }
}
