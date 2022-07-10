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

    public class CategoriesRepository : ICategories
        {
            private readonly IDapperGenericRepository _dapperGenericRepository;
        

        public CategoriesRepository(IDapperGenericRepository dapperGenericRepository)
            {
                _dapperGenericRepository = dapperGenericRepository;
            }
            public async Task<List<Categories>> GetCategories()
            {
                return await _dapperGenericRepository.Query<Categories>(SqlConstants.CategoriesListQuery);
            }
        public async Task<List<Categories>> GetCategoriesById(int id)
        {
            return await _dapperGenericRepository.Query<Categories>(SqlConstants.CategoriesListQueryById, new { @id = id });
        }

        public async Task<int> AddCategories(Categories categories)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.AddCategoriesQuery, new { categoryName = categories.CategoryName, createdBy = 3 });
        }
        public async Task<int> UpdateCategories(Categories categories)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.UpdateCategoriesQuery, new { categoryName = categories.CategoryName, modifiedBy = 3, CategoryId = categories.CategoryId });
        }
        public async Task<int> DeleteCategories(int id)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.DeleteCategoriesQuery, new { @id = id });
        }

    }
    }

