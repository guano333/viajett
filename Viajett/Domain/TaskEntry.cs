using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("TaskEntry")]
    public partial class TaskEntry
    {
        public Guid TaskEntryId { get; set; }

        public Guid EmployeeId { get; set; }

        public Guid ReportingPeriodId { get; set; }

        public Guid TaskId { get; set; }

        public decimal Hours { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ReportingPeriod ReportingPeriod { get; set; }

        public virtual Task Task { get; set; }
    }
}
