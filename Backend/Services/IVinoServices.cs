using Backend.Models;

namespace Backend.Services
{
    public interface IVinoServices
    {
        Task<List<Vino>> GetVinos();
        Task<Vino> GetVino(int id);
        Task<Vino> AddVino(Vino vino);
        Task<bool> DeleteVino(int id);
    }
}