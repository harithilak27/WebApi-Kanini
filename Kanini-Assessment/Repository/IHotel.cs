using Microsoft.AspNetCore.Mvc;
using Kanini_Assessment.Models;
using System.Threading.Tasks;

namespace Kanini_Assessment.Repository
{
    public interface IHotel
    {
        Task<Hotels> PostHotel(Hotels hotel);
    }
}
