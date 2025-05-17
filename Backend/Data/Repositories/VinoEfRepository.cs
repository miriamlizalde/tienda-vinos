using Microsoft.EntityFrameworkCore;
using Backend.Models;
using Backend.Data;


namespace Backend.Data
{
    public class VinoEfRepository : IVinoRepository
    {

        private readonly BackendDbContext _dbContext;

        public VinoEfRepository(BackendDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Vino>> GetVinos()
        {
            return await _dbContext.Vinos.ToListAsync();
        }
        public async Task<Vino> GetVino(int id)
        {
            return await _dbContext.Vinos.FindAsync(id);
        }
        public async Task<Vino> AddVino(Vino vino)
        {
            _dbContext.Vinos.Add(vino);
            await _dbContext.SaveChangesAsync();
            return vino;
        }

        public async Task<bool> DeleteVino(int id)
        {
            var vino = await _dbContext.Vinos.FindAsync(id);
            if (vino == null)
            {
                return false;
            }
            _dbContext.Vinos.Remove(vino);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        
        
    }
}