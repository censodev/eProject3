﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201205093044_init5")]
    partial class init5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.Faq", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Faqs");
                });

            modelBuilder.Entity("Data.Models.QuestionOption", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<long?>("SurveyQuestionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SurveyQuestionId");

                    b.ToTable("QuestionOption");
                });

            modelBuilder.Entity("Data.Models.Survey", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("Data.Models.SurveyAnswer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Answer")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<long?>("SurveyResultId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SurveyResultId");

                    b.ToTable("SurveyAnswers");
                });

            modelBuilder.Entity("Data.Models.SurveyQuestion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Answer")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<long?>("SurveyId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("SurveyQuestions");
                });

            modelBuilder.Entity("Data.Models.SurveyResult", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Mark")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<long?>("SurveyId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.HasIndex("UserId");

                    b.ToTable("SurveyResults");
                });

            modelBuilder.Entity("Data.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfJoining")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RollNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UserRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Data.Models.QuestionOption", b =>
                {
                    b.HasOne("Data.Models.SurveyQuestion", null)
                        .WithMany("Options")
                        .HasForeignKey("SurveyQuestionId");
                });

            modelBuilder.Entity("Data.Models.Survey", b =>
                {
                    b.HasOne("Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Data.Models.SurveyAnswer", b =>
                {
                    b.HasOne("Data.Models.SurveyResult", null)
                        .WithMany("Answers")
                        .HasForeignKey("SurveyResultId");
                });

            modelBuilder.Entity("Data.Models.SurveyQuestion", b =>
                {
                    b.HasOne("Data.Models.Survey", null)
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId");
                });

            modelBuilder.Entity("Data.Models.SurveyResult", b =>
                {
                    b.HasOne("Data.Models.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId");

                    b.HasOne("Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
