using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Contract.Inferfaces
{
    public interface ICategories
    {
        Task<List<Categories>> GetCategories();
        Task<List<Categories>> GetCategoriesById(int id);

        Task<int> AddCategories(Categories categories);
        Task<int> UpdateCategories(Categories categories);
        Task<int> DeleteCategories(int id);
    }
}
