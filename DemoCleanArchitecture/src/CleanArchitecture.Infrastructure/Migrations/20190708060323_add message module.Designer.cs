﻿// <auto-generated />
using System;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CleanArchitecture.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190708060323_add message module")]
    partial class addmessagemodule
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Accounts.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int?>("EmployeeId");

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

                    b.HasIndex("EmployeeId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.HR.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Location");

                    b.Property<string>("Location2");

                    b.Property<string>("Location3");

                    b.Property<int?>("ManagerId");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentId");

                    b.Property<string>("Phone");

                    b.Property<string>("Phone2");

                    b.Property<string>("Phone3");

                    b.Property<bool>("Removed");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.HasIndex("ParentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.HR.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Code");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("FullName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone");

                    b.Property<bool>("Removed");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.HR.EmployeeJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmpoyeeJobs");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.HR.EmployeeJobRequirement", b =>
                {
                    b.Property<int>("EmployeeJobId");

                    b.Property<int>("JobRequirementId");

                    b.HasKey("EmployeeJobId");

                    b.HasAlternateKey("JobRequirementId");

                    b.ToTable("EmployeeJobRequirements");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.HR.JobRequirement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("JobRequirements");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Sales.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DistributorCode");

                    b.Property<int?>("DistributorId");

                    b.Property<string>("Fullname");

                    b.Property<DateTime>("ModifiedTime");

                    b.Property<string>("Owner");

                    b.Property<string>("Phone");

                    b.Property<string>("Receiver");

                    b.Property<string>("Shortname");

                    b.HasKey("Id");

                    b.HasIndex("DistributorId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Sales.Distributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Distributors");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int?>("CreatedById");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("AutoMessageConfigs");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutoMessageConfigId");

                    b.Property<string>("Content");

                    b.Property<int?>("CreatedById");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Period");

                    b.Property<int>("VersionNumber");

                    b.HasKey("Id");

                    b.HasIndex("AutoMessageConfigId");

                    b.HasIndex("CreatedById");

                    b.ToTable("AutoMessageConfigDetails");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetailsMessageReceiver", b =>
                {
                    b.Property<int>("MessageReceiverId");

                    b.Property<int>("AutoMessageConfigDetailsId");

                    b.HasKey("MessageReceiverId", "AutoMessageConfigDetailsId");

                    b.HasIndex("AutoMessageConfigDetailsId");

                    b.ToTable("AutoMesasgeConfigDetailsMessageReceivers");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetailsMessageReceiverGroup", b =>
                {
                    b.Property<int>("AutoMessageConfigDetailsId");

                    b.Property<int>("MessageReceiverGroupId");

                    b.HasKey("AutoMessageConfigDetailsId", "MessageReceiverGroupId");

                    b.HasIndex("MessageReceiverGroupId");

                    b.ToTable("AutoMessageConfigDetailsMessageReceiverGroups");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetailsProvider", b =>
                {
                    b.Property<int>("AutoMessageConfigDetailsId");

                    b.Property<int>("MessageServiceProviderId");

                    b.HasKey("AutoMessageConfigDetailsId", "MessageServiceProviderId");

                    b.HasIndex("MessageServiceProviderId");

                    b.ToTable("AutoMessageConfigDetailsProviders");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.MessageReceiver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<int?>("CustomerId");

                    b.Property<int?>("EmployeeId");

                    b.Property<string>("FullName");

                    b.Property<int?>("ReceiverCategoryId");

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ReceiverCategoryId");

                    b.ToTable("MessageReceivers");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.MessageReceiverGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MessageReceiverGroups");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.MessageReceiverGroupMessageReceiver", b =>
                {
                    b.Property<int>("MessageReceiverGroupId");

                    b.Property<int>("MessageReceiverId");

                    b.HasKey("MessageReceiverGroupId", "MessageReceiverId");

                    b.HasIndex("MessageReceiverId");

                    b.ToTable("MessageReceiverGroupMessageReceivers");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.MessageServiceProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("MessageServiceProviders");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.ReceiverCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ReceiverCategories");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.ReceiverProvider", b =>
                {
                    b.Property<int>("MessageServiceProviderId");

                    b.Property<int>("MessageReceiverId");

                    b.Property<int?>("CreatedBy");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("ReceiverAddress");

                    b.HasKey("MessageServiceProviderId", "MessageReceiverId");

                    b.HasIndex("MessageReceiverId");

                    b.ToTable("ReceiverProviders");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.SentMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AutoMessageConfigDetailsId");

                    b.Property<string>("Content");

                    b.Property<DateTime?>("ReceiveTime");

                    b.Property<int>("ReceiverProviderId");

                    b.Property<int?>("ReceiverProviderMessageReceiverId");

                    b.Property<int?>("ReceiverProviderMessageServiceProviderId");

                    b.Property<DateTime>("SendTime");

                    b.Property<int?>("SentBy");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("AutoMessageConfigDetailsId");

                    b.HasIndex("ReceiverProviderMessageServiceProviderId", "ReceiverProviderMessageReceiverId");

                    b.ToTable("SentMessages");
                });

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

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Accounts.AppUser", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.HR.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.HR.Department", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.HR.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.HasOne("CleanArchitecture.Core.Entities.HR.Department", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.HR.Employee", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.HR.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.HR.EmployeeJob", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.HR.Employee", "Employee")
                        .WithMany("EmployeeJobs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.HR.EmployeeJobRequirement", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.HR.EmployeeJob", "EmployeeJob")
                        .WithMany("EmployeeJobRequirements")
                        .HasForeignKey("EmployeeJobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CleanArchitecture.Core.Entities.HR.JobRequirement", "JobRequirement")
                        .WithMany("EmployeeJobRequirements")
                        .HasForeignKey("JobRequirementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Sales.Customer", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Sales.Distributor", "Distributor")
                        .WithMany()
                        .HasForeignKey("DistributorId");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfig", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.HR.Employee", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetails", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfig", "AutoMessageConfig")
                        .WithMany("Versions")
                        .HasForeignKey("AutoMessageConfigId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CleanArchitecture.Core.Entities.HR.Employee", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetailsMessageReceiver", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetails", "AutoMessageConfigDetails")
                        .WithMany("AutoMessageConfigDetailsMessageReceivers")
                        .HasForeignKey("AutoMessageConfigDetailsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.MessageReceiver", "MessageReceiver")
                        .WithMany()
                        .HasForeignKey("MessageReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetailsMessageReceiverGroup", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetails", "AutoMessaegConfigDetails")
                        .WithMany("AutoMessageConfigDetailsMessageReceiverGroups")
                        .HasForeignKey("AutoMessageConfigDetailsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.MessageReceiverGroup", "MessageReceiveGroup")
                        .WithMany()
                        .HasForeignKey("MessageReceiverGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetailsProvider", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetails", "AutoMessageConfigDetails")
                        .WithMany("AutoMessageConfigDetailsProviders")
                        .HasForeignKey("AutoMessageConfigDetailsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.MessageServiceProvider", "MessageServiceProvider")
                        .WithMany()
                        .HasForeignKey("MessageServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.MessageReceiver", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Sales.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.HasOne("CleanArchitecture.Core.Entities.HR.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.ReceiverCategory", "ReceiverCategory")
                        .WithMany("MessageReceivers")
                        .HasForeignKey("ReceiverCategoryId");
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.MessageReceiverGroupMessageReceiver", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.MessageReceiverGroup", "MessageReceiverGroup")
                        .WithMany("MessageReceiverGroupMessageReceivers")
                        .HasForeignKey("MessageReceiverGroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.MessageReceiver", "MessageReceiver")
                        .WithMany("MessageReceiverGroupMessageReceivers")
                        .HasForeignKey("MessageReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.ReceiverProvider", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.MessageReceiver", "MessageReceiver")
                        .WithMany("ReceiverProviders")
                        .HasForeignKey("MessageReceiverId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.MessageServiceProvider", "MessageServiceProvider")
                        .WithMany("ReceiverProviders")
                        .HasForeignKey("MessageServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CleanArchitecture.Core.Entities.Messaging.SentMessage", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.AutoMessageConfigDetails", "AutoMessageConfigDetails")
                        .WithMany()
                        .HasForeignKey("AutoMessageConfigDetailsId");

                    b.HasOne("CleanArchitecture.Core.Entities.Messaging.ReceiverProvider", "ReceiverProvider")
                        .WithMany()
                        .HasForeignKey("ReceiverProviderMessageServiceProviderId", "ReceiverProviderMessageReceiverId");
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
                    b.HasOne("CleanArchitecture.Core.Entities.Accounts.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Accounts.AppUser")
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

                    b.HasOne("CleanArchitecture.Core.Entities.Accounts.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CleanArchitecture.Core.Entities.Accounts.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
