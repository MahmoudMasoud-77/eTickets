using eTickets.Data;
using eTickets.Models;

namespace eTickets.Repository
{
    public class ActorRepository : IActorRepository
    {
        private readonly AppDbContext context;
        public ActorRepository(AppDbContext _context)
        {
            this.context = _context;
        }

        public List<Actor> GetAll()
        {
            return  context.Actors.ToList();
        }

        public Actor GetById(int id)
        {
            return context.Actors.FirstOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            Actor actor = GetById(id);
            context.Actors.Remove(actor);
            context.SaveChanges();
        }
        public void Insert(Actor NewItem)
        {
            context.Actors.Add(NewItem);
            context.SaveChanges();
        }

        public void Update(int id, Actor NewItem)
        {
            Actor OldActor = GetById(id);
            OldActor.Bio=NewItem.Bio;
            OldActor.FullName=NewItem.FullName;
            OldActor.ProfilePictureURL=NewItem.ProfilePictureURL;
            context.SaveChanges();
        }
    }
}
