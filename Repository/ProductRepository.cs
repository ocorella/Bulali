using Bulali.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulali.Core.Repository
{
    public class ProductRepository
    {
        private static List<ProductGroup> productGroups = new List<ProductGroup>()
        {
            new ProductGroup()
            {
                ProductGroupId = 1, Title = "Bebidas", ImagePath ="", Products = new List<Product>()
                {
                    new Product()
                    {
                        ProductId = 1,
                        Name = "Ensalada Cesar",
                        ShortDescription = "The best",
                        Description = " Ensalada Cesar ak7 con cohete comprela ya o se va a ir volando",
                        ImagePath = "Ensalada",
                        Available = true,
                        PrepTime = 10,
                        Ingredients = new List<string>() {"Pan", "pollo", "lechuga"},
                        Price = 120,
                        IsFavorite = true
                    },
                    new Product()
                    {
                         ProductId = 2,
                         Name = "Regular product",
                         ShortDescription = "The best",
                         Description = " Ensalada Cesar",
                         ImagePath = "Ensalada",
                         Available = true,
                         PrepTime = 10,
                         Ingredients = new List<string>() { "Pan", "pollo", "lechuga" },
                         Price = 1,
                         IsFavorite = false
                    }
                }
            }
        };

        public List<Product> GetAllProducts()
        {
            IEnumerable<Product> products =
                from productGroup in productGroups
                from product in productGroup.Products

                select product;
            return products.ToList<Product>();
        }

        public Product GetProductById(int productId)
        {
            IEnumerable<Product> products =
                from productGroup in productGroups
                from product in productGroup.Products
                where product.ProductId == productId
                select product;

            return products.FirstOrDefault();
        }

        public List<ProductGroup> GetGroupedProducts()
        {
            return productGroups;
        }

        public List<Product> GetProductsForGroup(int productGroupId)
        {
            var group = productGroups.Where(h => h.ProductGroupId == productGroupId).FirstOrDefault();

            if (group != null)
            {
                return group.Products;
            }
            return null;
        }

        public List<Product> GetFavoriteProducts()
        {
            IEnumerable<Product> products =
                from productGroup in productGroups
                from product in productGroup.Products
                where product.IsFavorite
                select product;

            return products.ToList<Product>();
        }

    }
}

