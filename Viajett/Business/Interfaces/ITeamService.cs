using Domain;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ITeamService
    {
        Team UpsertTeam(Team source);
        void DeleteTeam(Team source);
        void SetManager(Team source, Employee manager);
    }
}
