using Backend.Models;
namespace Backend.Services
{
    public interface IBodegaServices
    {
        Task<List<Bodega>> GetBodegas();
        Task<Bodega> GetBodega(int id);
        Task<Bodega> AddBodega(Bodega bodega);
        Task<bool> DeleteBodega(int id);
    }
}