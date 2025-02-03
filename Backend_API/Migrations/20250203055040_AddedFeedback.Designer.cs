﻿// <auto-generated />
using System;
using Backend_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Backend_API.Migrations
{
    [DbContext(typeof(Backend_APIContext))]
    [Migration("20250203055040_AddedFeedback")]
    partial class AddedFeedback
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend_API.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Cats"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Weather"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Food"
                        });
                });

            modelBuilder.Entity("Backend_API.Models.Content", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContentId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ContentId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Content");

                    b.HasData(
                        new
                        {
                            ContentId = 1,
                            Author = "Author",
                            Body = "body",
                            CategoryId = 1,
                            CreatedAt = new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "1Title",
                            UpdatedAt = new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContentId = 2,
                            Author = "Author",
                            Body = "body",
                            CategoryId = 2,
                            CreatedAt = new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "2Title",
                            UpdatedAt = new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContentId = 3,
                            Author = "Author",
                            Body = "body",
                            CategoryId = 3,
                            CreatedAt = new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "3Title",
                            UpdatedAt = new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ContentId = 4,
                            Author = "Author",
                            Body = "body",
                            CategoryId = 4,
                            CreatedAt = new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "4Title",
                            UpdatedAt = new DateTime(2025, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Backend_API.Models.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("FeedbackId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("Backend_API.Models.Content", b =>
                {
                    b.HasOne("Backend_API.Models.Category", "Category")
                        .WithMany("PostedContent")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Backend_API.Models.Category", b =>
                {
                    b.Navigation("PostedContent");
                });
#pragma warning restore 612, 618
        }
    }
}
