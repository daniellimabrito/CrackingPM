﻿// <auto-generated />
using System;
using DLB.CrackingPM.Services.Stakeholder.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DLB.CrackingPM.Services.Stakeholder.Data.Migrations
{
    [DbContext(typeof(CrackingPMDataContext))]
    partial class CrackingPMDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DLB.CrackingPM.Services.Stakeholder.Domain.Stakeholders", b =>
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

                    b.HasKey("Id");

                    b.ToTable("stakeholders");
                });
#pragma warning restore 612, 618
        }
    }
}
