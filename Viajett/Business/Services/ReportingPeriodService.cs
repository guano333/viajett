using Business.Interfaces;
using Domain;
using System;

namespace Business.Services
{
    public class ReportingPeriodService : IReportingPeriodService
    {
        public void DeleteReportingPeriod(ReportingPeriod source)
        {
            throw new NotImplementedException();
        }

        public ReportingPeriod GetCurrentReportingPeriod()
        {
            throw new NotImplementedException();
        }

        public ReportingPeriod GetReportingPeriodByYearAndPeriodNumber(int year, int reportingPeriodNumber)
        {
            throw new NotImplementedException();
        }

        public int GetTotalHoursAvailableInReportingPeriod(ReportingPeriod reportingPeriod)
        {
            throw new NotImplementedException();
        }

        public ReportingPeriod UpsertReportingPeriod(ReportingPeriod source)
        {
            throw new NotImplementedException();
        }
    }
}
