﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Scedulo.Server.Data;

namespace Scedulo.Server.Data.Migations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0-preview2.19525.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AddressId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("HeightInCM")
                        .HasColumnType("int");

                    b.Property<bool>("IsEmployed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
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

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Base.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Line2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Customers.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<bool>("Newsleter")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Employees.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddedById")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("BaseMonthSalary")
                        .HasColumnType("float");

                    b.Property<DateTimeOffset?>("ContractEndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("EditedById")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("EmploymentDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("UpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AddedById");

                    b.HasIndex("EditedById");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Employees.EmployeePermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiringDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoleId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId1");

                    b.HasIndex("RoleId1");

                    b.ToTable("EmployeePermissions");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Employees.EmployeeRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeRoles");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Rooms.Equipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Equipments");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Rooms.RoleRoomPermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoomId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoomId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ServiceRoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ServiceRoleId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoomId1");

                    b.HasIndex("ServiceRoleId1");

                    b.ToTable("RoleRoomPermissions");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Rooms.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Rooms.RoomEquipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EquimpentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EquipmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoomId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoomId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("RoomId1");

                    b.ToTable("RoomEquipment");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Schedules.EmployeeSchedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AbsenceReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("FinishTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("Present")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("StartTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId1");

                    b.ToTable("EmployeeSchedules");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.ServiceReservations.ServiceReservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AbsenceReason")
                        .HasColumnType("text");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CustomerId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("Done")
                        .HasColumnType("bit");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("EstimatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("ReservationTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("ServiceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ServiceId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId1");

                    b.HasIndex("EmployeeId1");

                    b.HasIndex("ServiceId1");

                    b.ToTable("ServiceReservations");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Services.RoleServicePermssion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ServiceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ServiceId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ServiceRoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ServiceRoleId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId1");

                    b.HasIndex("ServiceRoleId1");

                    b.ToTable("RoleServicePermission");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Services.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PriceInPln")
                        .HasColumnType("float");

                    b.Property<bool>("RoleReqired")
                        .HasColumnType("bit");

                    b.Property<int>("TimeRequiredInMinutes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Base.Address", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", "User")
                        .WithOne("Address")
                        .HasForeignKey("Scedulo.Server.Data.Entities.Base.Address", "UserId");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Customers.Customer", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Employees.Employee", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", "AddedBy")
                        .WithMany()
                        .HasForeignKey("AddedById");

                    b.HasOne("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", "EditedBy")
                        .WithMany()
                        .HasForeignKey("EditedById");

                    b.HasOne("Scedulo.Server.Data.Entities.ApplicationUsers.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Employees.EmployeePermission", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.Employees.Employee", "Employee")
                        .WithMany("AvailablePermissions")
                        .HasForeignKey("EmployeeId1");

                    b.HasOne("Scedulo.Server.Data.Entities.Employees.EmployeeRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId1");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Rooms.RoleRoomPermission", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.Rooms.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId1");

                    b.HasOne("Scedulo.Server.Data.Entities.Employees.EmployeeRole", "ServiceRole")
                        .WithMany("AvailableRooms")
                        .HasForeignKey("ServiceRoleId1");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Rooms.RoomEquipment", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.Rooms.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId");

                    b.HasOne("Scedulo.Server.Data.Entities.Rooms.Room", "Room")
                        .WithMany("AvailableEquipments")
                        .HasForeignKey("RoomId1");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Schedules.EmployeeSchedule", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.Employees.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId1");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.ServiceReservations.ServiceReservation", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.Customers.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId1");

                    b.HasOne("Scedulo.Server.Data.Entities.Employees.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId1");

                    b.HasOne("Scedulo.Server.Data.Entities.Services.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId1");
                });

            modelBuilder.Entity("Scedulo.Server.Data.Entities.Services.RoleServicePermssion", b =>
                {
                    b.HasOne("Scedulo.Server.Data.Entities.Services.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId1");

                    b.HasOne("Scedulo.Server.Data.Entities.Employees.EmployeeRole", "ServiceRole")
                        .WithMany("AvailableServices")
                        .HasForeignKey("ServiceRoleId1");
                });
#pragma warning restore 612, 618
        }
    }
}
