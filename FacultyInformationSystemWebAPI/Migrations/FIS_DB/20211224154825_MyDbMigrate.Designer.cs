﻿// <auto-generated />
using System;
using FacultyInformationSystemWebAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FacultyInformationSystemWebAPI.Migrations.FIS_DB
{
    [DbContext(typeof(FIS_DBContext))]
    [Migration("20211224154825_MyDbMigrate")]
    partial class MyDbMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CourseID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseCredits")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("DeptId")
                        .HasColumnType("int")
                        .HasColumnName("DeptID");

                    b.HasKey("CourseId");

                    b.HasIndex("DeptId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.CourseSubject", b =>
                {
                    b.Property<int>("CourseSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CourseSubjectID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int")
                        .HasColumnName("SubjectID");

                    b.HasKey("CourseSubjectId");

                    b.HasIndex("CourseId");

                    b.HasIndex("SubjectId");

                    b.ToTable("CourseSubject");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.CourseTaught", b =>
                {
                    b.Property<int>("CourseTaughtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CourseTaughtID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasColumnName("CourseID");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int")
                        .HasColumnName("FacultyID");

                    b.Property<DateTime?>("FirstDateTaught")
                        .HasColumnType("date");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int")
                        .HasColumnName("SubjectID");

                    b.HasKey("CourseTaughtId");

                    b.HasIndex("CourseId");

                    b.HasIndex("FacultyId");

                    b.HasIndex("SubjectId");

                    b.ToTable("CourseTaught");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DeptID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("DeptId")
                        .HasName("Dept_ID_PK");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Designation", b =>
                {
                    b.Property<int>("DesignationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DesignationID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DesignationName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("DesignationId");

                    b.ToTable("Designation");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FacultyID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("DateOfBirth")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int")
                        .HasColumnName("DeptID");

                    b.Property<int?>("DesignationId")
                        .HasColumnType("int")
                        .HasColumnName("DesignationID");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("FacultyAddress")
                        .IsRequired()
                        .HasMaxLength(75)
                        .IsUnicode(false)
                        .HasColumnType("varchar(75)");

                    b.Property<string>("FacultyState")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("Faculty_State");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("HireDate")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("LastName")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<decimal?>("MobileNo")
                        .HasColumnType("numeric(10,0)");

                    b.Property<int>("Pincode")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacultyId");

                    b.HasIndex("DeptId");

                    b.HasIndex("DesignationId");

                    b.HasIndex(new[] { "MobileNo" }, "UQ__Faculty__D6D73A8638616B3E")
                        .IsUnique()
                        .HasFilter("[MobileNo] IS NOT NULL");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.FacultyDegree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DegreeID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("DegreeYear")
                        .HasColumnType("int");

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int")
                        .HasColumnName("FacultyID");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("char(2)")
                        .IsFixedLength(true);

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("DegreeId")
                        .HasName("Faculty_Degrees_ID_PK");

                    b.HasIndex("FacultyId");

                    b.ToTable("Faculty_Degrees");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Grant", b =>
                {
                    b.Property<int>("GrantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GrantID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FacultyId")
                        .HasColumnType("int")
                        .HasColumnName("FacultyID");

                    b.Property<string>("GrantDescription")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("GrantTitle")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("GrantId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Grants");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Publication", b =>
                {
                    b.Property<string>("PublicationId")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("PublicationID");

                    b.Property<string>("ArticleName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .IsUnicode(false)
                        .HasColumnType("varchar(75)");

                    b.Property<DateTime>("CitationDate")
                        .HasColumnType("date");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int")
                        .HasColumnName("FacultyID");

                    b.Property<string>("PublicationLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PublicationTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .IsUnicode(false)
                        .HasColumnType("varchar(75)");

                    b.HasKey("PublicationId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SubjectID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<byte[]>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("binary(16)")
                        .IsFixedLength(true);

                    b.HasKey("UserId");

                    b.HasIndex(new[] { "UserName" }, "UQ__Users__C9F2845684AB4D4C")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.WorkHistory", b =>
                {
                    b.Property<int>("WorkHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WorkHistoryID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyId")
                        .HasColumnType("int")
                        .HasColumnName("FacultyID");

                    b.Property<DateTime>("JobBeginDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("JobEndDate")
                        .HasColumnType("date");

                    b.Property<string>("JobResponsibilities")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("JobTitle")
                        .HasMaxLength(75)
                        .IsUnicode(false)
                        .HasColumnType("varchar(75)");

                    b.Property<string>("JobType")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Organization")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("WorkHistoryId");

                    b.HasIndex("FacultyId");

                    b.ToTable("WorkHistory");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Course", b =>
                {
                    b.HasOne("FacultyInformationSystemWebAPI.Model.Department", "Dept")
                        .WithMany("Courses")
                        .HasForeignKey("DeptId")
                        .HasConstraintName("Department_Course_ID_FK")
                        .IsRequired();

                    b.Navigation("Dept");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.CourseSubject", b =>
                {
                    b.HasOne("FacultyInformationSystemWebAPI.Model.Course", "Course")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("CourseSubject_CourseID_FK")
                        .IsRequired();

                    b.HasOne("FacultyInformationSystemWebAPI.Model.Subject", "Subject")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("CourseSubject_SubjectID_FK")
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.CourseTaught", b =>
                {
                    b.HasOne("FacultyInformationSystemWebAPI.Model.Course", "Course")
                        .WithMany("CourseTaughts")
                        .HasForeignKey("CourseId")
                        .HasConstraintName("Courses_Course_ID_CourseTaught_FK")
                        .IsRequired();

                    b.HasOne("FacultyInformationSystemWebAPI.Model.Faculty", "Faculty")
                        .WithMany("CourseTaughts")
                        .HasForeignKey("FacultyId")
                        .HasConstraintName("CourseTaught_FacultyID_FK")
                        .IsRequired();

                    b.HasOne("FacultyInformationSystemWebAPI.Model.Subject", "Subject")
                        .WithMany("CourseTaughts")
                        .HasForeignKey("SubjectId")
                        .HasConstraintName("CourseTaught_SubjectID_FK")
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Faculty");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Faculty", b =>
                {
                    b.HasOne("FacultyInformationSystemWebAPI.Model.Department", "Dept")
                        .WithMany("Faculties")
                        .HasForeignKey("DeptId")
                        .HasConstraintName("Dept_Faculty_FK");

                    b.HasOne("FacultyInformationSystemWebAPI.Model.Designation", "Designation")
                        .WithMany("Faculties")
                        .HasForeignKey("DesignationId")
                        .HasConstraintName("Designation_Faculty_FK");

                    b.Navigation("Dept");

                    b.Navigation("Designation");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.FacultyDegree", b =>
                {
                    b.HasOne("FacultyInformationSystemWebAPI.Model.Faculty", "Faculty")
                        .WithMany("FacultyDegrees")
                        .HasForeignKey("FacultyId")
                        .HasConstraintName("Degree_FacultyID_FK");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Grant", b =>
                {
                    b.HasOne("FacultyInformationSystemWebAPI.Model.Faculty", "Faculty")
                        .WithMany("Grants")
                        .HasForeignKey("FacultyId")
                        .HasConstraintName("Faculty_Grants_FK");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Publication", b =>
                {
                    b.HasOne("FacultyInformationSystemWebAPI.Model.Faculty", "Faculty")
                        .WithMany("Publications")
                        .HasForeignKey("FacultyId")
                        .HasConstraintName("Faculty_ID_FK")
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.WorkHistory", b =>
                {
                    b.HasOne("FacultyInformationSystemWebAPI.Model.Faculty", "Faculty")
                        .WithMany("WorkHistories")
                        .HasForeignKey("FacultyId")
                        .HasConstraintName("Faculty_Work_ID_FK")
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Course", b =>
                {
                    b.Navigation("CourseSubjects");

                    b.Navigation("CourseTaughts");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Faculties");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Designation", b =>
                {
                    b.Navigation("Faculties");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Faculty", b =>
                {
                    b.Navigation("CourseTaughts");

                    b.Navigation("FacultyDegrees");

                    b.Navigation("Grants");

                    b.Navigation("Publications");

                    b.Navigation("WorkHistories");
                });

            modelBuilder.Entity("FacultyInformationSystemWebAPI.Model.Subject", b =>
                {
                    b.Navigation("CourseSubjects");

                    b.Navigation("CourseTaughts");
                });
#pragma warning restore 612, 618
        }
    }
}
