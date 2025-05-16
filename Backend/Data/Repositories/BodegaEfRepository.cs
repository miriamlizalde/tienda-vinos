using Microsoft.EntityFrameworkCore;
using Backend.Models;
using Backend.Data;


namespace Backend.Data
{
    public class BodegaEfRepository : IBodegaRepository
    {

        private readonly BackendDbContext _dbContext;

        public BodegaEfRepository(BackendDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Bodega>> GetBodegas()
        {
            return await _dbContext.Bodegas.ToListAsync();
        }
        public async Task<Bodega> GetBodega(int id)
        {
            return await _dbContext.Bodegas.FindAsync(id);
            
        }
        public async Task<Bodega> AddBodega(Bodega bodega)
        {
            _dbContext.Bodegas.Add(bodega);
            await _dbContext.SaveChangesAsync();
            return bodega;
        }

        public async Task<bool> DeleteBodega(int id)
        {
            var bodega = await _dbContext.Bodegas.FindAsync(id);
            if (bodega == null)
            {
                return false;
            }
            _dbContext.Bodegas.Remove(bodega);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        
        
    }
}