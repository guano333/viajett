using Domain;
using System;
using System.Collections.Generic;

namespace Data.Interfaces
{
    public interface IReportingPeriodRepository
    {
        ReportingPeriod GetById(Guid reportingPeriod);
        IEnumerable<ReportingPeriod> GetAll();
        ReportingPeriod Upsert(ReportingPeriod source);
        void Delete(Guid reportingPeriodId);
    }
}
