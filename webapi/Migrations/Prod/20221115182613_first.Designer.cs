﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using webapi.Data;

#nullable disable

namespace webapi.Migrations.Prod
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221115182613_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("webapi.Entities.DockerContainer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("ContainerPort")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExposedPort")
                        .HasColumnType("text");

                    b.Property<string>("Hash")
                        .HasColumnType("text");

                    b.Property<string>("HostPort")
                        .HasColumnType("text");

                    b.Property<string>("RepositoryName")
                        .HasMaxLength(264)
                        .HasColumnType("character varying(264)");

                    b.Property<string>("SocketBind")
                        .HasColumnType("text");

                    b.Property<string>("Tag")
                        .HasMaxLength(264)
                        .HasColumnType("character varying(264)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Volume")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("docker_container", (string)null);
                });

            modelBuilder.Entity("webapi.Entities.DockerImage", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CurrentVersion")
                        .HasColumnType("text");

                    b.Property<string>("Hash")
                        .HasColumnType("text");

                    b.Property<string>("NewestVersion")
                        .HasColumnType("text");

                    b.Property<bool>("NewestVersionPulled")
                        .HasColumnType("boolean");

                    b.Property<string>("RepositoryName")
                        .HasMaxLength(264)
                        .HasColumnType("character varying(264)");

                    b.Property<string>("Tag")
                        .HasMaxLength(264)
                        .HasColumnType("character varying(264)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("docker_image", (string)null);
                });

            modelBuilder.Entity("webapi.Models.Log", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Application")
                        .HasColumnType("text");

                    b.Property<string>("CallSite")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Exception")
                        .HasColumnType("text");

                    b.Property<string>("Level")
                        .HasColumnType("text");

                    b.Property<string>("Logger")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("logs", (string)null);
                });

            modelBuilder.Entity("webapi.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreatedById")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("UpdatedById");

                    b.ToTable("roles", (string)null);
                });

            modelBuilder.Entity("webapi.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("CreatedById")
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .HasMaxLength(320)
                        .HasColumnType("character varying(320)");

                    b.Property<string>("FamilyName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("GivenName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastLoginAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("LoginFailedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("LoginFailedCount")
                        .HasColumnType("integer");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UpdatedById")
                        .HasColumnType("uuid");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("IsActive");

                    b.HasIndex("RoleId");

                    b.HasIndex("UpdatedById");

                    b.HasIndex("Username");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("webapi.Entities.DockerContainer", b =>
                {
                    b.HasOne("webapi.Models.User", "User")
                        .WithMany("DockerContainers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("webapi.Entities.DockerImage", b =>
                {
                    b.HasOne("webapi.Models.User", "User")
                        .WithMany("DockerImages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("webapi.Models.Role", b =>
                {
                    b.HasOne("webapi.Models.User", "CreatedBy")
                        .WithMany("CreatedRoles")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webapi.Models.User", "UpdatedBy")
                        .WithMany("UpdatedRoles")
                        .HasForeignKey("UpdatedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("UpdatedBy");
                });

            modelBuilder.Entity("webapi.Models.User", b =>
                {
                    b.HasOne("webapi.Models.User", "CreatedBy")
                        .WithMany("CreatedUsers")
                        .HasForeignKey("CreatedById");

                    b.HasOne("webapi.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.HasOne("webapi.Models.User", "UpdatedBy")
                        .WithMany("UpdatedUsers")
                        .HasForeignKey("UpdatedById");

                    b.Navigation("CreatedBy");

                    b.Navigation("Role");

                    b.Navigation("UpdatedBy");
                });

            modelBuilder.Entity("webapi.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("webapi.Models.User", b =>
                {
                    b.Navigation("CreatedRoles");

                    b.Navigation("CreatedUsers");

                    b.Navigation("DockerContainers");

                    b.Navigation("DockerImages");

                    b.Navigation("UpdatedRoles");

                    b.Navigation("UpdatedUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
