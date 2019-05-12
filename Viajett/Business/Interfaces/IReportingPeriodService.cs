using Domain;

namespace Business.Interfaces
{
    public interface IReportingPeriodService
    {
        ReportingPeriod GetCurrentReportingPeriod();
        ReportingPeriod UpsertReportingPeriod(ReportingPeriod source);
        void DeleteReportingPeriod(ReportingPeriod source);
        ReportingPeriod GetReportingPeriodByYearAndPeriodNumber(int year, int reportingPeriodNumber);
        int GetTotalHoursAvailableInReportingPeriod(ReportingPeriod reportingPeriod);
    }
}
