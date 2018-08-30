﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PCBuilder.Data;

namespace PCBuilder.Data.Migrations
{
    [DbContext(typeof(PCBuilderContext))]
    partial class PCBuilderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PCBuilder.Models.Case", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CaseType")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FormFactor")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("NumberOfPorts");

                    b.Property<int>("NumberOfVents");

                    b.Property<decimal>("Price");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ModelName")
                        .IsUnique();

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("PCBuilder.Models.GraphicsCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Architecture")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("CoreSpeed");

                    b.Property<string>("DirectX")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("MaxPower");

                    b.Property<int>("MemoryAmount");

                    b.Property<string>("MemorySpeed")
                        .IsRequired();

                    b.Property<string>("MemoryType")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Pipelines");

                    b.Property<decimal>("Price");

                    b.Property<string>("Socket")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ModelName")
                        .IsUnique();

                    b.ToTable("GraphicsCards");
                });

            modelBuilder.Entity("PCBuilder.Models.HardDiskDrive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cache");

                    b.Property<string>("Interface")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("MemoryCapacity");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price");

                    b.Property<int>("ReadSpeed");

                    b.Property<int>("Rpm");

                    b.Property<int>("WriteSpeed");

                    b.HasKey("Id");

                    b.HasIndex("ModelName")
                        .IsUnique();

                    b.ToTable("HardDiskDrives");
                });

            modelBuilder.Entity("PCBuilder.Models.Memory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("Frequency");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ModulesType")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price");

                    b.Property<string>("Socket")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ModelName")
                        .IsUnique();

                    b.ToTable("Memory");
                });

            modelBuilder.Entity("PCBuilder.Models.Motherboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chipset")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FormFactor")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("GraphicsCardSocketNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("HDDInterface")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("MaxMemory");

                    b.Property<string>("MemorySocketNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("MemoryType")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("NumberOfMemorySlots");

                    b.Property<string>("PowerConnector")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price");

                    b.Property<string>("ProcessorSocketNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("SSDInterface")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ModelName")
                        .IsUnique();

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("PCBuilder.Models.PC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BuildName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("CaseId");

                    b.Property<int>("GraphicsCardId");

                    b.Property<int?>("HardDiskDriveId");

                    b.Property<double>("MaxSystemRating");

                    b.Property<int>("MemoryId");

                    b.Property<int>("MotherboardId");

                    b.Property<int>("NumberOfMemorySticks");

                    b.Property<int>("PowerSupplyId");

                    b.Property<int>("ProcessorId");

                    b.Property<int?>("SolidStateDriveId");

                    b.Property<double>("SystemRating");

                    b.Property<string>("SystemSummary");

                    b.Property<decimal>("TotalPrice");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.Property<double>("UserRating");

                    b.Property<int>("UsersRatedCount");

                    b.Property<string>("UsersRatedIds");

                    b.HasKey("Id");

                    b.HasIndex("BuildName")
                        .IsUnique();

                    b.HasIndex("CaseId");

                    b.HasIndex("GraphicsCardId");

                    b.HasIndex("HardDiskDriveId");

                    b.HasIndex("MemoryId");

                    b.HasIndex("MotherboardId");

                    b.HasIndex("PowerSupplyId");

                    b.HasIndex("ProcessorId");

                    b.HasIndex("SolidStateDriveId");

                    b.HasIndex("UserId");

                    b.ToTable("PCs");
                });

            modelBuilder.Entity("PCBuilder.Models.PowerSupply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Connector")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Effectiveness");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("NumberOfCoolingVents");

                    b.Property<string>("Pfc")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("Power");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("ModelName")
                        .IsUnique();

                    b.ToTable("PowerSupplies");
                });

            modelBuilder.Entity("PCBuilder.Models.Processor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Architecture")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("Cache");

                    b.Property<double>("Frequency");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("MaxMemorySize")
                        .HasMaxLength(100);

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("NumberOfCores");

                    b.Property<double>("Power");

                    b.Property<decimal>("Price");

                    b.Property<string>("Socket")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ModelName")
                        .IsUnique();

                    b.ToTable("Processors");
                });

            modelBuilder.Entity("PCBuilder.Models.SolidStateDrive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Interface")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<double>("MemoryCapacity");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Price");

                    b.Property<int>("ReadSpeed");

                    b.Property<int>("WriteSpeed");

                    b.HasKey("Id");

                    b.HasIndex("ModelName")
                        .IsUnique();

                    b.ToTable("SolidStateDrives");
                });

            modelBuilder.Entity("PCBuilder.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PCBuilder.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PCBuilder.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PCBuilder.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PCBuilder.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PCBuilder.Models.PC", b =>
                {
                    b.HasOne("PCBuilder.Models.Case", "Case")
                        .WithMany("PCs")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PCBuilder.Models.GraphicsCard", "GraphicsCard")
                        .WithMany("PCs")
                        .HasForeignKey("GraphicsCardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PCBuilder.Models.HardDiskDrive", "HardDiskDrive")
                        .WithMany("PCs")
                        .HasForeignKey("HardDiskDriveId");

                    b.HasOne("PCBuilder.Models.Memory", "Memory")
                        .WithMany("PCs")
                        .HasForeignKey("MemoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PCBuilder.Models.Motherboard", "Motherboard")
                        .WithMany("PCs")
                        .HasForeignKey("MotherboardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PCBuilder.Models.PowerSupply", "PowerSupply")
                        .WithMany("PCs")
                        .HasForeignKey("PowerSupplyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PCBuilder.Models.Processor", "Processor")
                        .WithMany("PCs")
                        .HasForeignKey("ProcessorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PCBuilder.Models.SolidStateDrive", "SolidStateDrive")
                        .WithMany("PCs")
                        .HasForeignKey("SolidStateDriveId");

                    b.HasOne("PCBuilder.Models.User", "User")
                        .WithMany("Builds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
