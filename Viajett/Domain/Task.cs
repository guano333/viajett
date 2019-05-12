using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("Task")]
    public partial class Task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task()
        {
            TaskEntries = new HashSet<TaskEntry>();
        }

        public Guid TaskId { get; set; }

        public Guid? TeamId { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        public Guid TaskCategoryId { get; set; }

        public bool? IsActive { get; set; }

        public virtual TaskCategory TaskCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskEntry> TaskEntries { get; set; }
    }
}
