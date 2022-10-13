﻿// <auto-generated />
using BamBoo_SoftToothbrush.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BamBoo_SoftToothbrush.Migrations.BamBoo_SoftToothbrush
{
    [DbContext(typeof(BamBoo_SoftToothbrushContext))]
    partial class BamBoo_SoftToothbrushContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BamBoo_SoftToothbrush.Models.BrushClass", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bristles_Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BrushSize")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Review")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("BrushClass");
                });
#pragma warning restore 612, 618
        }
    }
}
