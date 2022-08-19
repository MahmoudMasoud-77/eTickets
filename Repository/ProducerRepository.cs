using eTickets.Data;
using eTickets.Models;

namespace eTickets.Repository
{
    public class ProducerRepository:IProduserRepository
    {
        private readonly AppDbContext context;
        public ProducerRepository(AppDbContext _context)
        {
            this.context = _context;
        }

        public List<Producer> GetAll()
        {
            return context.Producers.ToList();
        }

        public Producer GetById(int id)
        {
            return context.Producers.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            Producer producer = GetById(id);
            context.Producers.Remove(producer);
            context.SaveChanges();
        }
        public void Insert(Producer NewItem)
        {
            context.Producers.Add(NewItem);
            context.SaveChanges();
        }

        public void Update(int id, Producer NewItem)
        {
            Producer OldItem = GetById(id);
            OldItem.Bio = NewItem.Bio;
            OldItem.ProfilePictureURL = NewItem.ProfilePictureURL;
            OldItem.FullName = NewItem.FullName;
            context.SaveChanges();
        }
    }
}
