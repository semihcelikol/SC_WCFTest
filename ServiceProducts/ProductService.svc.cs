using System.Collections.Generic;
using System.Linq;

namespace ServiceProducts
{
    public class ProductService : IProductService
    {
        private List<Product> GetProductList()
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < 10; i++)
            {
                Product product = new Product();

                product.Id = i;
                product.Name = $"Product - {i}";
                product.Description = $"Product - {i} Description";
                product.Qty = i + i;

                products.Add(product);
            }

            return products;
        }

        public Product GetProductById(int id)
        {
            List<Product> products = GetProductList();

            if (products.Exists(x => x.Id == id))
            {
                return products.FirstOrDefault(x => x.Id == id);
            }

            throw new System.Exception("Ürün bulunamadı !");
        }
    }

}