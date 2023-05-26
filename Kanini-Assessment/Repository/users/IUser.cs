using Microsoft.AspNetCore.Mvc;
using Kanini_Assessment.Models;
using System.Threading.Tasks;

namespace Kanini_Assessment.Repository.users
{
    public interface IUser
    {
        public Task<User> PostUser(User user);
    }
}
