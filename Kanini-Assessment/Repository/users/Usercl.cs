using Kanini_Assessment.Models;
using Kanini_Assessment.Repository.Room;
using Kanini_Assessment.Repository.users;

namespace Kanini_Assessment.Repository.users
{
    public class Usercl : IUser
    {
        private readonly HotelContext _context;

        public Usercl(HotelContext context)
        {
            _context = context;
        }

        public async Task<User> PostUser(User users)
        {
            var itm = await _context.users.AddAsync(users);
            if (itm == null)
            {
                throw new Exception("error");
            }
            _context.SaveChanges();
            return users;
        }
    }
}
