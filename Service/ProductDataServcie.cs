using Bulali.Core.Model;
using Bulali.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulali.Core.Service
{
    public class ProductDataServcie
    {
        private static ProductRepository productRepository = new ProductRepository();

        public List<Product> GetAllProducts()
        {
            return productRepository.GetAllProducts();
        }

        public List<ProductGroup> GetGroupedProducts()
        {
            return productRepository.GetGroupedProducts();
        }

        public List<Product> GetProductsForGroup(int productGroupId)
        {
            return productRepository.GetProductsForGroup(productGroupId);
        }

        public List<Product> GetFavoriteProducts() {
            return productRepository.GetFavoriteProducts();
        }

        public Product GetProductById(int productId) {
            return productRepository.GetProductById(productId);
        }


    }
}
