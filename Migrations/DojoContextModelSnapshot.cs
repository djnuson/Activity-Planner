﻿// <auto-generated />
using System;
using DojoActivity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DojoActivity.Migrations
{
    [DbContext(typeof(DojoContext))]
    partial class DojoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DojoActivity.ActivityModel", b =>
                {
                    b.Property<int>("ActId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Duration")
                        .IsRequired();

                    b.Property<DateTime>("Time");

                    b.Property<string>("TimeForm")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("ActId");

                    b.HasIndex("UserId");

                    b.ToTable("ActTable");
                });

            modelBuilder.Entity("DojoActivity.Participants", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActId");

                    b.Property<int>("UserId");

                    b.HasKey("PartId");

                    b.HasIndex("ActId");

                    b.HasIndex("UserId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("DojoActivity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("UserTable");
                });

            modelBuilder.Entity("DojoActivity.ActivityModel", b =>
                {
                    b.HasOne("DojoActivity.User", "Coordinator")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DojoActivity.Participants", b =>
                {
                    b.HasOne("DojoActivity.ActivityModel", "activmodel")
                        .WithMany("participant")
                        .HasForeignKey("ActId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DojoActivity.User", "User")
                        .WithMany("participant")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
