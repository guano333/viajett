using Business.Interfaces;
using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public void DeleteTeam(Team source)
        {
            if (source != null)
            {
                _teamRepository.Delete(source.TeamId);
            }
        }

        public void SetManager(Team source, Employee manager)
        {
            if (source != null && manager != null)
            {
                source.ManagerId = manager.EmployeeId;
                _teamRepository.Upsert(source);
            }
        }

        public Team UpsertTeam(Team source)
        {
            if (source != null)
            {
                _teamRepository.Upsert(source);
            }
            return source;
        }
    }
}
