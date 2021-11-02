using ASP.NET_Core_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Demo
{
    public interface IProductRepository
    {
        //Introduction functionality
        public IEnumerable<Product> GetAllProducts();
        //View functionality
        public Product GetProduct(int id);
        //Update Functionality
        public void UpdateProduct(Product product);
        //Insert functionality
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
    }
}
