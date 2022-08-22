using eTickets.Models;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<List<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task InsertAsync(Actor NewItem);
        Task UpdateAsync(int id, Actor NewItem);
        Task DeleteAsync(int id);

    }
}
