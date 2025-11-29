using Fantasy.Shared.Entities;
using Fantasy.Shared.Responses;

namespace Fantasy.Backend.Repositories.Interfaces;

public interface ICountriesRepository
{
    Task<ActionResponse<IEnumerable<Country>>> GetAsync();

    Task<ActionResponse<Country>> GetAsync(int id);

    Task<IEnumerable<Country>> GetComboAsync();
}