namespace Data
{
    using Domain;
    using System.Data.Entity;

    public partial class Viajett : DbContext
    {
        public Viajett()
            : base("name=ViajettConnectionString")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ReportingPeriod> ReportingPeriods { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskCategory> TaskCategories { get; set; }
        public virtual DbSet<TaskEntry> TaskEntries { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.TaskEntries)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReportingPeriod>()
                .HasMany(e => e.TaskEntries)
                .WithRequired(e => e.ReportingPeriod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Task>()
                .HasMany(e => e.TaskEntries)
                .WithRequired(e => e.Task)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaskCategory>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<TaskCategory>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.TaskCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaskEntry>()
                .Property(e => e.Hours)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Team>()
                .Property(e => e.TeamName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);
        }
    }
}
