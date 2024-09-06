﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TasksManager.API.Data;

#nullable disable

namespace TasksManager.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TasksManager.API.Models.Collaborator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Collaborators");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dfaeee36-623b-4ec5-af23-b15f4cf87b6d"),
                            CreatedAt = new DateTime(2024, 9, 4, 15, 9, 45, 921, DateTimeKind.Utc).AddTicks(9988),
                            IsDeleted = false,
                            Name = "Edu Brandão",
                            UserId = new Guid("4f3c7efd-fca5-4469-b0a0-bff6236c4040")
                        });
                });

            modelBuilder.Entity("TasksManager.API.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f2c6fbc-1bbb-48c1-9b53-c84e8b58cec9"),
                            CreatedAt = new DateTime(2024, 9, 4, 15, 9, 45, 922, DateTimeKind.Utc).AddTicks(8),
                            IsDeleted = false,
                            Name = "Projeto Validações"
                        });
                });

            modelBuilder.Entity("TasksManager.API.Models.TaskModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("acd96614-b660-4a01-924d-3b464caa2ec3"),
                            CreatedAt = new DateTime(2024, 9, 4, 15, 9, 45, 922, DateTimeKind.Utc).AddTicks(29),
                            Description = "Levantamento de Requisitos da demanda",
                            IsDeleted = false,
                            Name = "Levantamento de Requisitos",
                            ProjectId = new Guid("9f2c6fbc-1bbb-48c1-9b53-c84e8b58cec9")
                        },
                        new
                        {
                            Id = new Guid("9d98439f-30b6-43fc-b302-a60fb3561657"),
                            CreatedAt = new DateTime(2024, 9, 4, 15, 9, 45, 922, DateTimeKind.Utc).AddTicks(45),
                            Description = "Analisando atividades da demanda",
                            IsDeleted = false,
                            Name = "Análise da demanada",
                            ProjectId = new Guid("9f2c6fbc-1bbb-48c1-9b53-c84e8b58cec9")
                        },
                        new
                        {
                            Id = new Guid("7138dcdc-8c23-463d-953e-e4289627833c"),
                            CreatedAt = new DateTime(2024, 9, 4, 15, 9, 45, 922, DateTimeKind.Utc).AddTicks(63),
                            Description = "Desenvolver tela para cadastro de usuários",
                            IsDeleted = false,
                            Name = "Desenvolvimento atividade 1",
                            ProjectId = new Guid("9f2c6fbc-1bbb-48c1-9b53-c84e8b58cec9")
                        });
                });

            modelBuilder.Entity("TasksManager.API.Models.TimeTracker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CollaboratorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TaskModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TimeZoneId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CollaboratorId");

                    b.HasIndex("TaskModelId");

                    b.ToTable("TimeTrackers");
                });

            modelBuilder.Entity("TasksManager.API.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("nvarchar(512)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4f3c7efd-fca5-4469-b0a0-bff6236c4040"),
                            CreatedAt = new DateTime(2024, 9, 4, 15, 9, 45, 921, DateTimeKind.Utc).AddTicks(9819),
                            IsDeleted = false,
                            Password = "123@Test",
                            UserName = "Edu Brandão"
                        });
                });

            modelBuilder.Entity("TasksManager.API.Models.Collaborator", b =>
                {
                    b.HasOne("TasksManager.API.Models.User", null)
                        .WithOne("Collaborator")
                        .HasForeignKey("TasksManager.API.Models.Collaborator", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TasksManager.API.Models.TaskModel", b =>
                {
                    b.HasOne("TasksManager.API.Models.Project", null)
                        .WithMany("Tasks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TasksManager.API.Models.TimeTracker", b =>
                {
                    b.HasOne("TasksManager.API.Models.Collaborator", null)
                        .WithMany("TimeTrackers")
                        .HasForeignKey("CollaboratorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TasksManager.API.Models.TaskModel", null)
                        .WithMany("TimeTrackers")
                        .HasForeignKey("TaskModelId");
                });

            modelBuilder.Entity("TasksManager.API.Models.Collaborator", b =>
                {
                    b.Navigation("TimeTrackers");
                });

            modelBuilder.Entity("TasksManager.API.Models.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("TasksManager.API.Models.TaskModel", b =>
                {
                    b.Navigation("TimeTrackers");
                });

            modelBuilder.Entity("TasksManager.API.Models.User", b =>
                {
                    b.Navigation("Collaborator")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
