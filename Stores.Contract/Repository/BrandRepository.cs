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
    public class BrandRepository: IBrand
    {
        private readonly IDapperGenericRepository _dapperGenericRepository;
        public BrandRepository(IDapperGenericRepository dapperGenericRepository)
        {
           _dapperGenericRepository = dapperGenericRepository;
        }
        public async Task<List<Brand>> GetBrands()
        {
            return await _dapperGenericRepository.Query<Brand>(SqlConstants.BrandListQuery);
        }
        public async Task<List<Brand>> GetBrandById(int id)
        {
            return await _dapperGenericRepository.Query<Brand>(SqlConstants.BrandListQueryById,new { @id=id});
        }
        public async Task<int> AddBrand(Brand brand)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.AddBrandQuery, new { brandName = brand.BrandName, createdBy  = 3});
        }
        public async Task<int> UpdateBrand(Brand brand)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.UpdateBrandQuery, new { brandName = brand.BrandName, modifiedBy = 3,brandId=brand.BrandId });
        }
        public async Task<int> DeleteBrand(int id)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.DeleteBrandQuery, new { @id = id });
        }
    }
}
