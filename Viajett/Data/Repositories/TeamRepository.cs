using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public void Delete(Guid teamId)
        {
            using (var context = new Viajett())
            {
                var team = context.Teams.Where(x => x.TeamId == teamId).FirstOrDefault();
                if (team != null)
                {
                    context.Teams.Remove(team);
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<Team> GetAll()
        {
            using (var context = new Viajett())
            {
                return context.Teams.ToList();
            }
        }

        public Team GetById(Guid teamId)
        {
            using (var context = new Viajett())
            {
                var team = context.Teams.Where(x => x.TeamId == teamId).FirstOrDefault();
                return team;
            }
        }

        public Team Upsert(Team source)
        {
            if (source != null)
            {
                using (var context = new Viajett())
                {
                    var team = context.Teams.Where(x => x.TeamId == source.TeamId).FirstOrDefault();
                    if (team != null)
                    {
                        //update
                        team.TeamName = source.TeamName;
                        team.ManagerId = source.ManagerId;
                        context.SaveChanges();
                        return team;
                    }
                    else
                    {
                        //insert
                        context.Teams.Add(source);
                        context.SaveChanges();
                        return team;
                    }
                }
            }
            return null;
        }
    }
}