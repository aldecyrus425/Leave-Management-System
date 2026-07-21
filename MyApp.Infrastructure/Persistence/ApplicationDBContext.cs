using Microsoft.EntityFrameworkCore;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>(e =>
            {
                e.HasKey(x => x.DepartmentId);

                e.HasMany(x => x.Employees)
                .WithOne(x => x.Department)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Employees>(e =>
            {
                e.HasKey(x => x.DepartmentId);
            });

            modelBuilder.Entity<HolidayCalendar>(e =>
            {
                e.HasKey(x => x.HolidayId);
            });

            modelBuilder.Entity<LeaveAccrual>(e =>
            {
                e.HasKey(x => x.LeaveAccrualId);
            });

            modelBuilder.Entity<LeaveAdjustments>(e =>
            {
                e.HasKey(x => x.AdjustmentId);
            });

            modelBuilder.Entity<LeaveApprovals>(e =>
            {
                e.HasKey(x => x.LeaveApprovalId);
            });

            modelBuilder.Entity<LeaveAttachments>(e =>
            {
                e.HasKey(x => x.AttachmentId);
            });

            modelBuilder.Entity<LeaveBalances>(e =>
            {
                e.HasKey(x => x.LeaveBalanceId);
            });

            modelBuilder.Entity<LeaveLedger>(e =>
            {
                e.HasKey(x => x.LeaveLedgerId);
            });

            modelBuilder.Entity<LeavePolicies>(e =>
            {
                e.HasKey(x => x.LeavePolicyId);
            });

            modelBuilder.Entity<LeaveRequests>(e =>
            {
                e.HasKey(x => x.LeaveRequestId);
            });

            modelBuilder.Entity<LeaveTypes>(e =>
            {
                e.HasKey(x => x.LeaveTypeId);

                e.HasMany(x => x.LeaveRequests)
                .WithOne(x => x.LeaveType)
                .HasForeignKey(x => x.LeaveTypeId)
                .OnDelete(DeleteBehavior.Restrict);

                e.HasMany(x => x.LeaveBalances)
                .WithOne(x => x.LeaveType)
                .HasForeignKey(x => x.LeaveTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Positions>(e =>
            {
                e.HasKey(x => x.PositionId);

                e.HasMany(x => x.Employees)
                .WithOne(x => x.Position)
                .HasForeignKey(x => x.PositionId)
                .OnDelete(DeleteBehavior.Restrict);

            });

            modelBuilder.Entity<WorkCalendar>(e =>
            {
                e.HasKey(x => x.CalendarId);
            });




            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Departments> Departments { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<HolidayCalendar> HolidayCalendars { get; set; }
        public DbSet<LeaveAccrual> LeaveAccrual { get; set; }
        public DbSet<LeaveAdjustments> LeaveAdjustments { get; set; }
        public DbSet<LeaveApprovals> LeaveApprovals { get; set; }
        public DbSet<LeaveAttachments> LeaveAttachments { get; set; }
        public DbSet<LeaveBalances> LeaveBalances { get; set; }
        public DbSet<LeaveLedger> LeaveLedger { get; set; }
        public DbSet<LeavePolicies> LeavePolicies { get; set; }
        public DbSet<LeaveRequests> LeaveRequests { get; set; }
        public DbSet<LeaveTypes> LeaveTypes { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<WorkCalendar> WorkCalendar { get; set; }
    }
}
