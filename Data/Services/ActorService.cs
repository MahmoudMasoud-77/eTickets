using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorService:IActorsService
    {
        private readonly AppDbContext context;
        public ActorService(AppDbContext _context)
        {
            this.context = _context;
        }

        public async Task<List<Actor>> GetAllAsync()
        {
            return await context.Actors.ToListAsync();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            return await context.Actors.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            Actor actor = await GetByIdAsync(id);
            context.Actors.Remove(actor);
            await context.SaveChangesAsync();
        }
        public async Task InsertAsync(Actor NewItem)
        {
            await context.Actors.AddAsync(NewItem);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, Actor NewItem)
        {
            Actor OldActor = await GetByIdAsync(id);
            OldActor.Bio = NewItem.Bio;
            OldActor.FullName = NewItem.FullName;
            OldActor.ProfilePictureURL = NewItem.ProfilePictureURL;
            await context.SaveChangesAsync();
        }
    }
}
