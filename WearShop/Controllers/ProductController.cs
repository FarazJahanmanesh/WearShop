using Microsoft.AspNetCore.Mvc;
using WearShop.Contracts;
using WearShop.Models;
using WearShop.Models.ViewModels;

namespace WearShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICommentRepository _repositoryComment;
        private readonly IProductRepository _repositoryProduct;
        public ProductController(IProductRepository repositoryProduct, ICommentRepository repositoryComment)
        {
            _repositoryProduct = repositoryProduct;
            _repositoryComment = repositoryComment;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var product1 = await _repositoryProduct.ShowProduct(9);
            CommentProductViewModel a = new CommentProductViewModel{
                product= product1,
                comment=product1.comments[0]
            };
            return View(a);
        }
        [HttpPost]
        public IActionResult Index(Comment comment)
        {
            _repositoryComment.AddComment(comment);
            return Ok();
        }
    }
}
