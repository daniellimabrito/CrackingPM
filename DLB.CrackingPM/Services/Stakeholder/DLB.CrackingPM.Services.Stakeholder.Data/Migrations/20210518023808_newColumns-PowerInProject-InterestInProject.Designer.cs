﻿// <auto-generated />
using System;
using DLB.CrackingPM.Services.Stakeholder.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DLB.CrackingPM.Services.Stakeholder.Data.Migrations
{
    [DbContext(typeof(CrackingPMDataContext))]
    [Migration("20210518023808_newColumns-PowerInProject-InterestInProject")]
    partial class newColumnsPowerInProjectInterestInProject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DLB.CrackingPM.Services.Stakeholder.Domain.Models.Stakeholders", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Accessibility")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DirectResourceControl")
                        .HasColumnType("int");

                    b.Property<int>("InfluenceOther")
                        .HasColumnType("int");

                    b.Property<float>("InterestInProject")
                        .HasColumnType("real");

                    b.Property<int>("InterestLevelNonTechnical")
                        .HasColumnType("int");

                    b.Property<int>("InterestLevelTechnical")
                        .HasColumnType("int");

                    b.Property<int>("Knowledge")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PowerInProduct")
                        .HasColumnType("int");

                    b.Property<float>("PowerInProject")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("stakeholders");
                });
#pragma warning restore 612, 618
        }
    }
}