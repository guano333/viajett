using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public void Delete(Guid teamId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Team> GetAll()
        {
            throw new NotImplementedException();
        }

        public Team GetById(Guid team)
        {
            throw new NotImplementedException();
        }

        public Team Upsert(Team source)
        {
            throw new NotImplementedException();
        }
    }
}
