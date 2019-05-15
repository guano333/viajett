using Business.Interfaces;
using Data.Interfaces;
using Domain;
using System;
using System.Linq;

namespace Business.Services
{
    public class ReportingPeriodService : IReportingPeriodService
    {
        private readonly IReportingPeriodRepository _reportingPeriodRepository;

        public ReportingPeriodService(IReportingPeriodRepository reportingPeriodRepository)
        {
            _reportingPeriodRepository = reportingPeriodRepository;
        }

        public void DeleteReportingPeriod(ReportingPeriod source)
        {
            if (source != null)
            {
                _reportingPeriodRepository.Delete(source.ReportingPeriodId);
            }
        }

        public ReportingPeriod GetCurrentReportingPeriod()
        {
            return _reportingPeriodRepository.GetAll()
                .Where(x => x.StartDate <= DateTime.Now.Date 
                && x.EndDate > DateTime.Now.Date).SingleOrDefault();
        }

        public ReportingPeriod GetReportingPeriodByYearAndPeriodNumber(int year, int reportingPeriodNumber)
        {
            return _reportingPeriodRepository.GetAll()
                .Where(x => x.Year == year && x.PeriodNumber == reportingPeriodNumber).SingleOrDefault();
        }

        public int GetTotalHoursAvailableInReportingPeriod(ReportingPeriod reportingPeriod)
        {
            return 160;
        }

        public ReportingPeriod UpsertReportingPeriod(ReportingPeriod source)
        {
            if (source != null)
            {
                _reportingPeriodRepository.Upsert(source);
            }
            return source;
        }
    }
}
