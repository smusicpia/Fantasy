using Fantasy.Shared.DTOs;
using Fantasy.Shared.Entities;
using Fantasy.Shared.Responses;

namespace Fantasy.Backend.UnitsOfWork.Interfaces;

public interface ITournamentTeamsUnitOfWork
{
    Task<ActionResponse<TournamentTeam>> AddAsync(TournamentTeamDTO tournamentTeamDTO);

    Task<ActionResponse<IEnumerable<TournamentTeam>>> GetAsync(PaginationDTO pagination);

    Task<IEnumerable<TournamentTeam>> GetComboAsync(int tournamentId);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}