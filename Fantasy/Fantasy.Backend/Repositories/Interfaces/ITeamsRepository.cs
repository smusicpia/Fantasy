using Fantasy.Shared.DTOs;
using Fantasy.Shared.Entities;
using Fantasy.Shared.Responses;

namespace Fantasy.Backend.Repositories.Interfaces;

public interface ITeamsRepository
{
    Task<ActionResponse<Team>> AddAsync(TeamDTO teamDTO);

    Task<ActionResponse<IEnumerable<Team>>> GetAsync();

    Task<ActionResponse<Team>> GetAsync(int id);

    Task<IEnumerable<Team>> GetComboAsync(int countryId);

    Task<ActionResponse<Team>> UpdateAsync(TeamDTO teamDTO);
}