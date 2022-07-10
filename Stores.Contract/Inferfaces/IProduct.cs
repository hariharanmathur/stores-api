using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Contract.Inferfaces
{
               public interface IProduct
    {
        Task<List<Product>> GetProducts();
        Task<List<Product>> GetProductById(int id);
        Task<int> AddProduct(Product product);
        Task<int> UpdateProduct(Product product);
        Task<int> DeleteProduct(int id);

    }
}
