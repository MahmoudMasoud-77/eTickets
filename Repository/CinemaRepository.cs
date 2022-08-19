using eTickets.Data;
using eTickets.Models;

namespace eTickets.Repository
{
    public class CinemaRepository:ICinemaRepository
    {
        private readonly AppDbContext context;
        public CinemaRepository(AppDbContext _context)
        {
            this.context = _context;
        }

        public List<Cinema> GetAll()
        {
            return context.Cinemies.ToList();
        }

        public Cinema GetById(int id)
        {
            return context.Cinemies.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            Cinema cinema = GetById(id);
            context.Cinemies.Remove(cinema);
            context.SaveChanges();
        }
        public void Insert(Cinema NewItem)
        {
            context.Cinemies.Add(NewItem);
            context.SaveChanges();
        }

        public void Update(int id, Cinema NewItem)
        {
            Cinema OldCinema = GetById(id);
            OldCinema.Name = NewItem.Name;
            OldCinema.Description = NewItem.Description;
            OldCinema.Logo = NewItem.Logo;
            context.SaveChanges();
        }
    }
}
