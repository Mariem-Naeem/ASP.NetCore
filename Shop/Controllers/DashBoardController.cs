using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Shop.Models;
using System.Collections.Immutable;

namespace Shop.Controllers
{
    public class DashBoardController : Controller
    {
        private static List<Product> _products= new List<Product>();
        private static List<Blog> _blogs = new List<Blog>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product products)
        {
            int id;
            if (_products.Count == 0)
            {
                id = 1;
            }
            else
            {
                id=_products.Max(x => x.Id)+1;
            }
                  products.Id= id;
            _products.Add(products);
            return RedirectToAction("index");
        }
        #region GetAll
        public IActionResult GetAllData()
        {
            return View(_products);
        }
        #endregion



        #region DeleteProduct
        public IActionResult Delete(int id)
        {
            Product product = _products.FirstOrDefault(x => x.Id == id);
            _products.Remove(product);
            return RedirectToAction("GetAllData");

        }
        #endregion




        #region Edit
        public IActionResult Edit(int id)
        {
            Product product = _products.FirstOrDefault(x => x.Id == id);  
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            Product product2 = _products.SingleOrDefault(c => c.Id == product.Id);
            product2.Id= product.Id;
            product2.Name= product.Name;
            product2.Description= product.Description;
            product2.enablsize= product.enablsize;
            product2.company.Id= product.company.Id;

            return RedirectToAction("index");
        }
        #endregion



        public IActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            int id;
            if (_blogs.Count == 0)
            {
                id = 1;
            }
            else
            {
                id= _blogs.Max(x => x.Id)+1;
            }
            blog.Id = id;   
            _blogs.Add(blog);
            return RedirectToAction("index");
        }
        #region GetBlog
        public IActionResult GetBlog()
        {
            return View(_blogs);
        }
        #endregion


        #region DeleteBlog
        public IActionResult DeleteBlog(int id)
        {
            Blog blog= _blogs.FirstOrDefault(b=>b.Id==id);
            _blogs.Remove(blog);
            return RedirectToAction("GetBlog");
        }
        #endregion



        #region EditBlog
        public IActionResult EditBlog(int id)
        {
            Blog blog = _blogs.FirstOrDefault(b => b.Id == id);
            return View(blog);  

        }
        [HttpPost]
        public IActionResult EditBlog(Blog blog)
        {
            Blog blog1 = _blogs.FirstOrDefault(b => b.Id == blog.Id);
            blog1.Id=blog.Id;
            blog1.Title=blog.Title;
            blog1.Description=blog.Description;
            blog1.Name=blog.Name;
            blog1.enablsize=blog1.enablsize;
                return RedirectToAction("index");
        }

        #endregion
    }



}
