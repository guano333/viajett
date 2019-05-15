using Data.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class ReportingPeriodRepository : IReportingPeriodRepository
    {
        public void Delete(Guid reportingPeriodId)
        {
            using (var context = new Viajett())
            {
                var reportingPeriod = context.ReportingPeriods.Where(x => x.ReportingPeriodId == reportingPeriodId).FirstOrDefault();
                if (reportingPeriod != null)
                {
                    context.ReportingPeriods.Remove(reportingPeriod);
                    context.SaveChanges();
                }
            }
        }

        public IEnumerable<ReportingPeriod> GetAll()
        {
            using (var context = new Viajett())
            {
                return context.ReportingPeriods.ToList();
            }

        }

        public ReportingPeriod GetById(Guid reportingPeriodId)
        {
            using (var context = new Viajett())
            {
                var reportingPeriod = context.ReportingPeriods.Where(x => x.ReportingPeriodId == reportingPeriodId).FirstOrDefault();
                return reportingPeriod; ;
            }

        }

        public ReportingPeriod Upsert(ReportingPeriod source)
        {
            if (source != null)
            {
                using (var context = new Viajett())
                {
                    var reportingPeriod = context.ReportingPeriods.Where(x => x.ReportingPeriodId == source.ReportingPeriodId).FirstOrDefault();
                    if (reportingPeriod != null)
                    {
                        //update
                        reportingPeriod.Year = source.Year;
                        reportingPeriod.PeriodNumber = source.PeriodNumber;
                        reportingPeriod.StartDate = source.StartDate;
                        reportingPeriod.EndDate = source.EndDate;
                        context.SaveChanges();
                        return reportingPeriod;
                    }
                    else
                    {
                        //insert
                        context.ReportingPeriods.Add(source);
                        context.SaveChanges();
                        return reportingPeriod;
                    }
                }
            }
            return null;

        }
    }
}
