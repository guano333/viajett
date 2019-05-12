using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("ReportingPeriod")]
    public partial class ReportingPeriod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReportingPeriod()
        {
            TaskEntries = new HashSet<TaskEntry>();
        }

        public Guid ReportingPeriodId { get; set; }

        public int Year { get; set; }

        public int PeriodNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskEntry> TaskEntries { get; set; }
    }
}
