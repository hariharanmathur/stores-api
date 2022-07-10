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
     public class UserDetailsRepository : IUserDetails
    {
        private readonly IDapperGenericRepository _dapperGenericRepository;
        public UserDetailsRepository(IDapperGenericRepository dapperGenericRepository)
        {
            _dapperGenericRepository = dapperGenericRepository;
        }
        public async Task<List<UserDetails>> GetUserDetails()
        {
            return await _dapperGenericRepository.Query<UserDetails>(SqlConstants.UserDetailsListQuery);
        }
        public async Task<List<UserDetails>> GetUserDetailsById(int id)
        {
            return await _dapperGenericRepository.Query<UserDetails>(SqlConstants.UserDetailsListQueryById, new { @id = id });
        }
        public async Task<int> AddUserDetails(UserDetails userDetails)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.AddUserDetailsQuery, new { userdetailsName = userDetails.UserName,firstName = userDetails.FirstName,lastName = userDetails.LastName   });
        }
        public async Task<int> UpdateUserDetails(UserDetails userdetails)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.UpdateUserDetailsQuery, new { userName = userdetails.UserName, modifiedBy = 3, UserId = userdetails.UserId });
        }
        public async Task<int> DeleteUserDetails(int id)
        {
            return await _dapperGenericRepository.QueryExecuteAsync<int>(SqlConstants.DeleteUserDetailsQuery, new { @id = id });
        }
    }
}
