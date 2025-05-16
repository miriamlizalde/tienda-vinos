using Backend.Models;

namespace Backend.Data
{
    public interface IVinoRepository
    {
        Task<List<Vino>> GetVinos();
        Task<Vino> GetVino(int id);
        Task<Vino> AddVino(Vino vino);
        Task<bool> DeleteVino(int id);
    }
}