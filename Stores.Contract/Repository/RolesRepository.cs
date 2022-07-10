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
    public class RolesRepository : IRoles
    {
        private readonly IDapperGenericRepository _dapperGenericRepository;
        public RolesRepository(IDapperGenericRepository dapperGenericRepository)
        {
            _dapperGenericRepository = dapperGenericRepository;
        }
        public async Task<List<Roles>> GetRoles()
        {
            return await _dapperGenericRepository.Query<Roles>(SqlConstants.RolesListQuery);
        }
        public async Task<List<Roles>> GetRolesById(int id)
        {
            return await _dapperGenericRepository.Query<Roles>(SqlConstants.RolesListQueryById, new { @id = id });
        }
        public async Task<int> AddRoles(Roles roles)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.AddRolesQuery, new { rolesName = roles.RoleName, createdBy = 3 });
        }
        public async Task<int> UpdateRoles(Roles roles)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.UpdateRolesQuery, new { rolesName = roles.RoleName, modifiedBy = 3, rolesId = roles.RoleId });
        }
        public async Task<int> DeleteRoles(int id)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.DeleteRolesQuery, new { @id = id });
        }

    }
}
