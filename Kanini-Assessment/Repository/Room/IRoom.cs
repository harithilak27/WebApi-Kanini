using Microsoft.AspNetCore.Mvc;
using Kanini_Assessment.Models;
using System.Threading.Tasks;

namespace Kanini_Assessment.Repository.Room
{
    public interface IRoom
    {
        Task<Rooms> PostRoom(Rooms room);
        Task<IEnumerable<Rooms>> GetRooms();
        Task<Rooms> GetRoom(int id);
        Task<Rooms> PutRoom(int id, Rooms room);
        Task<string> DeleteRoom(int id);
    }
}
