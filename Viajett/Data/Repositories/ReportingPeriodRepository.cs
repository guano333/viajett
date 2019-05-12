using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;

namespace Data.Repositories
{
    public class ReportingPeriodRepository : IReportingPeriodRepository
    {
        public void Delete(Guid reportingPeriodId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReportingPeriod> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReportingPeriod GetById(Guid reportingPeriod)
        {
            throw new NotImplementedException();
        }

        public ReportingPeriod Upsert(ReportingPeriod source)
        {
            throw new NotImplementedException();
        }
    }
}
