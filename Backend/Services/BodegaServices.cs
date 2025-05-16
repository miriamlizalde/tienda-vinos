using Backend.Data;
using Backend.Models;

namespace Backend.Services
{
    public class BodegaServices : IBodegaServices
    {
        private readonly IBodegaRepository _bodegaRepository;
        public BodegaServices(IBodegaRepository bodegaRepository)
        {
            _bodegaRepository = bodegaRepository;

        }

        public async Task<List<Bodega>> GetBodegas()
        {
            return await _bodegaRepository.GetBodegas();
        }
        public async Task<Bodega> GetBodega(int id)
        {
            return await _bodegaRepository.GetBodega(id);
        }
        public async Task<Bodega> AddBodega(Bodega bodega)
        {
            return await _bodegaRepository.AddBodega(bodega);
        }
        public async Task<bool> DeleteBodega(int id)
        {
            return await _bodegaRepository.DeleteBodega(id);
        }
    }
}