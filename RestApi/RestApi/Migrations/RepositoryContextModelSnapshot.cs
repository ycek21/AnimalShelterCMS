﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RestApi.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Entities.Models.AdoptionApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AdoptionDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("UserId");

                    b.ToTable("AdoptionApplications");
                });

            modelBuilder.Entity("Entities.Models.Animal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimalTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Character")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("ColorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsDead")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<Guid>("SizeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<int>("WalkLimit")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnimalTypeId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ModifiedBy");

                    b.HasIndex("SizeId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("Entities.Models.AnimalType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("AnimalTypes");
                });

            modelBuilder.Entity("Entities.Models.Color", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("Entities.Models.Config", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.HasIndex("ModifiedBy");

                    b.ToTable("Configs");
                });

            modelBuilder.Entity("Entities.Models.Donation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FundraiserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FundraiserId");

                    b.HasIndex("UserId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("Entities.Models.Fundraiser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Target")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Fundraisers");
                });

            modelBuilder.Entity("Entities.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsProfilePicture")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Entities.Models.Size", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Models.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Accepted")
                        .HasColumnType("bit");

                    b.Property<Guid>("AnimalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("UserId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("Entities.Models.AdoptionApplication", b =>
                {
                    b.HasOne("Entities.Models.Animal", "Animal")
                        .WithMany("AdoptionApplications")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("AdoptionApplications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Animal", b =>
                {
                    b.HasOne("Entities.Models.AnimalType", "AnimalType")
                        .WithMany("Animals")
                        .HasForeignKey("AnimalTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.Color", "Color")
                        .WithMany("Animals")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Animals")
                        .HasForeignKey("ModifiedBy")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Entities.Models.Size", "Size")
                        .WithMany("Animals")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AnimalType");

                    b.Navigation("Color");

                    b.Navigation("Size");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Config", b =>
                {
                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Configs")
                        .HasForeignKey("ModifiedBy")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Donation", b =>
                {
                    b.HasOne("Entities.Models.Fundraiser", "Fundraiser")
                        .WithMany("Donations")
                        .HasForeignKey("FundraiserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Donations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Fundraiser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Fundraiser", b =>
                {
                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Fundraisers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Image", b =>
                {
                    b.HasOne("Entities.Models.Animal", "Animal")
                        .WithMany("Images")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("Entities.Models.Walk", b =>
                {
                    b.HasOne("Entities.Models.Animal", "Animal")
                        .WithMany("Walks")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.User", "User")
                        .WithMany("Walks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Models.Animal", b =>
                {
                    b.Navigation("AdoptionApplications");

                    b.Navigation("Images");

                    b.Navigation("Walks");
                });

            modelBuilder.Entity("Entities.Models.AnimalType", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("Entities.Models.Color", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("Entities.Models.Fundraiser", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("Entities.Models.Size", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Navigation("AdoptionApplications");

                    b.Navigation("Animals");

                    b.Navigation("Configs");

                    b.Navigation("Donations");

                    b.Navigation("Fundraisers");

                    b.Navigation("Walks");
                });
#pragma warning restore 612, 618
        }
    }
}
