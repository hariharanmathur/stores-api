using Stores.Models;

namespace Stores.Contract.Inferfaces
{
    public interface IBrand
    {
        Task<List<Brand>> GetBrands();
        Task<List<Brand>> GetBrandById(int id);
        Task<int> AddBrand(Brand brand);
        Task<int> UpdateBrand(Brand brand);
        Task<int> DeleteBrand(int id);

    }

}