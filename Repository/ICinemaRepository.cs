using eTickets.Models;

namespace eTickets.Repository
{
    public interface ICinemaRepository
    {
        List<Cinema> GetAll();
        Cinema GetById(int id);
        void Insert(Cinema NewCinema);
        void Update(int id, Cinema NewCinema);
        void Delete(int id);
    }
}
