using Stores.Contract.Inferfaces;
using Stores.DAL;
using Stores.Helpers;
using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Contract.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly IDapperGenericRepository _dapperGenericRepository;
        public ProductRepository(IDapperGenericRepository dapperGenericRepository)
        {
            _dapperGenericRepository = dapperGenericRepository;
        }
        public async Task<List<Product>> GetProducts()
        {
            return await _dapperGenericRepository.Query<Product>(SqlConstants.BrandListQuery);
        }
        public async Task<List<Product>> GetProductById(int id)
        {
            return await _dapperGenericRepository.Query<Product>(SqlConstants.ProductListQueryById, new { @id = id });
        }
        public async Task<int> AddProduct(Product product)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.AddProductQuery, new { productName = product.ProductName,model = product.Model,price = product.Price,productreleasdate = product.ProductReleaseDate });
        }
        public async Task<int> UpdateProduct(Product product)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.UpdateProductQuery, new { productName = product.ProductName, model = product.Model, price = product.Price, productreleasdate = product.ProductReleaseDate, modifiedBy = 3, productId = product.ProductId });
        }
        public async Task<int> DeleteProduct(int id)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.DeleteProductQuery, new { @id = id });
        }

    }
}
