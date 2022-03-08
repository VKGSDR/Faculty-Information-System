using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FacultyInformationSystemWebAPI.Model
{
    public partial class FIS_DBContext : DbContext
    {
        public FIS_DBContext()
        {
        }

        public FIS_DBContext(DbContextOptions<FIS_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSubject> CourseSubjects { get; set; }
        public virtual DbSet<CourseTaught> CourseTaughts { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<FacultyDegree> FacultyDegrees { get; set; }
        public virtual DbSet<Grant> Grants { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WorkHistory> WorkHistories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.;Trusted_Connection=True;Database=FIS_DB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Department_Course_ID_FK");
            });

            modelBuilder.Entity<CourseSubject>(entity =>
            {
                entity.ToTable("CourseSubject");

                entity.Property(e => e.CourseSubjectId).HasColumnName("CourseSubjectID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseSubjects)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CourseSubject_CourseID_FK");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.CourseSubjects)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CourseSubject_SubjectID_FK");
            });

            modelBuilder.Entity<CourseTaught>(entity =>
            {
                entity.ToTable("CourseTaught");

                entity.Property(e => e.CourseTaughtId).HasColumnName("CourseTaughtID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.FirstDateTaught).HasColumnType("date");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.CourseTaughts)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Courses_Course_ID_CourseTaught_FK");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.CourseTaughts)
                    .HasForeignKey(d => d.FacultyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CourseTaught_FacultyID_FK");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.CourseTaughts)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CourseTaught_SubjectID_FK");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("Dept_ID_PK");

                entity.ToTable("Department");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.ToTable("Designation");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.DesignationName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.ToTable("Faculty");

                entity.HasIndex(e => e.MobileNo, "UQ__Faculty__D6D73A8638616B3E")
                    .IsUnique();

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyAddress)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyState)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Faculty_State");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo).HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Faculties)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("Dept_Faculty_FK");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.Faculties)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("Designation_Faculty_FK");
            });

            modelBuilder.Entity<FacultyDegree>(entity =>
            {
                entity.HasKey(e => e.DegreeId)
                    .HasName("Faculty_Degrees_ID_PK");

                entity.ToTable("Faculty_Degrees");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.Degree)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.Grade)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Specialization)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.FacultyDegrees)
                    .HasForeignKey(d => d.FacultyId)
                    .HasConstraintName("Degree_FacultyID_FK");
            });

            modelBuilder.Entity<Grant>(entity =>
            {
                entity.Property(e => e.GrantId).HasColumnName("GrantID");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.GrantDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrantTitle)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Grants)
                    .HasForeignKey(d => d.FacultyId)
                    .HasConstraintName("Faculty_Grants_FK");
            });

            modelBuilder.Entity<Publication>(entity =>
            {
                entity.Property(e => e.PublicationId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PublicationID");

                entity.Property(e => e.ArticleName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CitationDate).HasColumnType("date");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.PublicationLocation)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublicationTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublisherName)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.Publications)
                    .HasForeignKey(d => d.FacultyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Faculty_ID_FK");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName, "UQ__Users__C9F2845684AB4D4C")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<WorkHistory>(entity =>
            {
                entity.ToTable("WorkHistory");

                entity.Property(e => e.WorkHistoryId).HasColumnName("WorkHistoryID");

                entity.Property(e => e.FacultyId).HasColumnName("FacultyID");

                entity.Property(e => e.JobBeginDate).HasColumnType("date");

                entity.Property(e => e.JobEndDate).HasColumnType("date");

                entity.Property(e => e.JobResponsibilities)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.JobType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Organization)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.WorkHistories)
                    .HasForeignKey(d => d.FacultyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Faculty_Work_ID_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
