﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Data;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20211221203024_AddCetgories")]
    partial class AddCetgories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("webapi.Data.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("RecordLabelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecordLabelId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("webapi.Data.MusicCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("webapi.Data.RecordLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("RecordLabel");
                });

            modelBuilder.Entity("webapi.Data.Vinyl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int?>("MusicCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("MusicCategoryId");

                    b.ToTable("Vinyl");
                });

            modelBuilder.Entity("webapi.Data.Artist", b =>
                {
                    b.HasOne("webapi.Data.RecordLabel", null)
                        .WithMany("Artists")
                        .HasForeignKey("RecordLabelId");
                });

            modelBuilder.Entity("webapi.Data.Vinyl", b =>
                {
                    b.HasOne("webapi.Data.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Data.MusicCategory", null)
                        .WithMany("Vinyls")
                        .HasForeignKey("MusicCategoryId");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("webapi.Data.MusicCategory", b =>
                {
                    b.Navigation("Vinyls");
                });

            modelBuilder.Entity("webapi.Data.RecordLabel", b =>
                {
                    b.Navigation("Artists");
                });
#pragma warning restore 612, 618
        }
    }
}