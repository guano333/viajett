using Domain;
using System;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface ITeamRepository
    {
        Team GetById(Guid team);
        IEnumerable<Team> GetAll();
        Team Upsert(Team source);
        void Delete(Guid teamId);
    }
}
