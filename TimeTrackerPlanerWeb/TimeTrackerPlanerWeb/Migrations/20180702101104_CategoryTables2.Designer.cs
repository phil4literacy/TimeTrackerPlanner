﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using TimeTrackerPlanerWeb.Models;

namespace TimeTrackerPlanerWeb.Migrations
{
    [DbContext(typeof(TasksContext))]
    [Migration("20180702101104_CategoryTables2")]
    partial class CategoryTables2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("TimeTrackerPlanerWeb.Models.TasksDoing", b =>
                {
                    b.Property<int>("workid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("duration");

                    b.Property<DateTime>("starttime");

                    b.Property<int>("taskid");

                    b.HasKey("workid");

                    b.ToTable("TasksDoing");
                });

            modelBuilder.Entity("TimeTrackerPlanerWeb.Models.TasksPlanned", b =>
                {
                    b.Property<int>("planid")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("TasksDoingworkid");

                    b.Property<int>("taskid");

                    b.HasKey("planid");

                    b.HasIndex("TasksDoingworkid");

                    b.ToTable("TasksPlanned");
                });

            modelBuilder.Entity("TimeTrackerPlanerWeb.Models.TasksPlanned", b =>
                {
                    b.HasOne("TimeTrackerPlanerWeb.Models.TasksDoing", "TasksDoing")
                        .WithMany("PlannedTasks")
                        .HasForeignKey("TasksDoingworkid");
                });
#pragma warning restore 612, 618
        }
    }
}
