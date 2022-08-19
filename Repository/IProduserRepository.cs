using eTickets.Models;

namespace eTickets.Repository
{
    public interface IProduserRepository
    {
        List<Producer> GetAll();
        Producer GetById(int id);
        void Insert(Producer NewItem);
        void Update(int id, Producer NewItem);
        void Delete(int id);
    }
}
