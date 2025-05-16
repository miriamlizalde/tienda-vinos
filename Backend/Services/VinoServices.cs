using Backend.Data;
using Backend.Models;

namespace Backend.Services
{
    public class VinoServices : IVinoServices
    {
        private readonly IVinoRepository _vinoRepository;
        
        public VinoServices(IVinoRepository vinoRepository)
        {
            _vinoRepository = vinoRepository;

        }

        public async Task<List<Vino>> GetVinos()
        {
            return await _vinoRepository.GetVinos();
        }
        public async Task<Vino> GetVino(int id)
        {
            return await _vinoRepository.GetVino(id);
        }
        public async Task<Vino> AddVino(Vino vino)
        {
            return await _vinoRepository.AddVino(vino);
        }
        public async Task<bool> DeleteVino(int id)
        {
            return await _vinoRepository.DeleteVino(id);
        }
    }
}