﻿// <auto-generated />
using System;
using CoreWebsite.EntityFramework;
using GeoAPI.Geometries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreWebsite.EntityFramework.Migrations
{
    [DbContext(typeof(WebsiteDbContext))]
    [Migration("20190219044012_UseGeometry_add_Road")]
    partial class UseGeometry_add_Road
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.Activity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.ActivityComment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ActivityId");

                    b.Property<string>("Content");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("ActivityComments");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.EntityRelationTest.AdmissionRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AdmissionTime");

                    b.Property<string>("Remark");

                    b.HasKey("Id");

                    b.ToTable("AdmissionRecords");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.EntityRelationTest.Class", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName");

                    b.Property<DateTime>("CreationTime");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.EntityRelationTest.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AdmissionRecordId");

                    b.Property<long>("ClassId");

                    b.Property<string>("Name");

                    b.Property<string>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("AdmissionRecordId")
                        .IsUnique();

                    b.HasIndex("ClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.EntityRelationTest.StudentTeacherRelationship", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("StudentId");

                    b.Property<long>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentTeacherRelationships");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.EntityRelationTest.Teacher", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("TeacherId");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.TreeTest.TreeNode", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NodeName");

                    b.Property<long?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("TreeNodes");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.UseGeometry.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.Property<IPoint>("Location");

                    b.HasKey("CityID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.UseGeometry.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<IGeometry>("Border");

                    b.Property<string>("CountryName");

                    b.HasKey("CountryID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.UseGeometry.Road", b =>
                {
                    b.Property<int>("RoadID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<ILinearRing>("Line");

                    b.Property<string>("RoadName");

                    b.HasKey("RoadID");

                    b.ToTable("Roads");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.ActivityComment", b =>
                {
                    b.HasOne("CoreWebsite.EntityFramework.Models.Activity", "Activity")
                        .WithMany("ActivityComments")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.EntityRelationTest.Student", b =>
                {
                    b.HasOne("CoreWebsite.EntityFramework.Models.EntityRelationTest.AdmissionRecord", "AdmissionRecord")
                        .WithOne("Student")
                        .HasForeignKey("CoreWebsite.EntityFramework.Models.EntityRelationTest.Student", "AdmissionRecordId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreWebsite.EntityFramework.Models.EntityRelationTest.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.EntityRelationTest.StudentTeacherRelationship", b =>
                {
                    b.HasOne("CoreWebsite.EntityFramework.Models.EntityRelationTest.Student", "Student")
                        .WithMany("StudentTeacherRelationships")
                        .HasForeignKey("StudentId");

                    b.HasOne("CoreWebsite.EntityFramework.Models.EntityRelationTest.Teacher", "Teacher")
                        .WithMany("StudentTeacherRelationships")
                        .HasForeignKey("TeacherId");
                });

            modelBuilder.Entity("CoreWebsite.EntityFramework.Models.TreeTest.TreeNode", b =>
                {
                    b.HasOne("CoreWebsite.EntityFramework.Models.TreeTest.TreeNode", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}
