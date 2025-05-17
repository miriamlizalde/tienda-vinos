using Backend.Models;

namespace Backend.Data
{
    public interface IBodegaRepository
    {
        Task<List<Bodega>> GetBodegas();
        Task<Bodega> GetBodega(int id);
        Task<Bodega> AddBodega(Bodega bodega);
        Task<bool> DeleteBodega(int id);
    }
}