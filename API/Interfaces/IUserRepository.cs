using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Udate(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUserAsync();
        Task<AppUser> GetUserByID(int id);
        Task<AppUser> GetUserByUserNameAsynce(string username);
        Task<IEnumerable<MemberDTOs>> GetMemberAsync();
        Task<MemberDTOs> GetMemberDTOs(string username);
    }
}