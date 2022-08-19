using eTickets.Models;

namespace eTickets.Repository
{
    public interface IActorRepository
    {
        List<Actor> GetAll();
        Actor GetById(int id);
        void Insert(Actor NewItem);
        void Update(int id,Actor NewItem);
        void Delete(int id);

    }
}
