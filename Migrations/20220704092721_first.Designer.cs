﻿// <auto-generated />
using System;
using Gestion_des_Stagiaires.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gestion_des_Stagiaires.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220704092721_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Gestion_des_Stagiaires.Models.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("Gestion_des_Stagiaires.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AttestationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DossierNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModefiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Organism")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Structure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThemeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TraineeType")
                        .HasColumnType("int");

                    b.Property<int>("Traineestatus")
                        .HasColumnType("int");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int");

                    b.Property<string>("TrainingDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TrainingEndedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TrainingStartedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TrainerId");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("Gestion_des_Stagiaires.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Structure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TraineesNumber")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("Gestion_des_Stagiaires.Models.Trainee", b =>
                {
                    b.HasOne("Gestion_des_Stagiaires.Models.Trainer", "Trainer")
                        .WithMany("Trainees")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Gestion_des_Stagiaires.Models.Trainer", b =>
                {
                    b.Navigation("Trainees");
                });
#pragma warning restore 612, 618
        }
    }
}
