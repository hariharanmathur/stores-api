using Stores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Contract.Inferfaces
{
    public interface IUserDetails
    {
        Task<List<UserDetails>> GetUserDetails();
        Task<List<UserDetails>> GetUserDetailsById(int id);
        Task<int> AddUserDetails(UserDetails userDetails);
        Task<int> UpdateUserDetails(UserDetails userdetails);
        Task<int> DeleteUserDetails(int id);
    }
}
