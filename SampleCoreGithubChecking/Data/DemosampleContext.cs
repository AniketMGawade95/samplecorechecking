using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SampleCoreGithubChecking.Models;

namespace SampleCoreGithubChecking.Data;

public partial class DemosampleContext : DbContext
{
    public DemosampleContext()
    {
    }

    public DemosampleContext(DbContextOptions<DemosampleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<SampleStudent> SampleStudents { get; set; }
    public virtual DbSet<Emp> Emps { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-IKD99J0\\SQLEXPRESS;Initial Catalog=demosample;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SampleStudent>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__SampleSt__32C52A79E79639AB");

            entity.ToTable("SampleStudent");

            entity.Property(e => e.StudentId).HasColumnName("StudentID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EnrollmentDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
