using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ProductDAO
    {

        private static List<Product> listProducts;

        public ProductDAO()
        {
            Product chai = new Product(1, "Chai", 1, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "Aniseed Syrup", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, aniseed };
        }

        public List<Product> GetProducts()
        {
            return listProducts;
        }

        public static List<Product> GetProducts()
        {
            var listProducts = new List<Product>();

            try
            {
                using var db = new MyStoreContext();
                listProducts = db.Products.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listProducts;
        }

        public void SaveProduct(Product p)
        {
            listProducts.Add(p);
        }

        public void UpdateProduct(Product p)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == p.ProductId)
                {
                    p.CategoryId = p.CategoryId;
                    p.ProductName = p.ProductName;
                    p.UnitPrice = p.UnitPrice;
                    p.UnitsInStock = p.UnitsInStock;
                    p.Category = p.Category;
                }
            }
        }

        public void DeleteProduct(Product p)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == p.ProductId)
                {
                    listProducts.Remove(p);
                }
            }
        }

        public Product GetProductById(int id)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == id)
                {
                    return p;
                }
            }
            return null;
        }

    }
}
