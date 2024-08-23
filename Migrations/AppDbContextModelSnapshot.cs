﻿// <auto-generated />
using System;
using Btl_web_nc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Btl_web_nc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Btl_web_nc.Models.Favourite", b =>
                {
                    b.Property<long>("favouriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("favouriteId"));

                    b.Property<long>("postId")
                        .HasColumnType("bigint");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("favouriteId");

                    b.HasIndex("postId");

                    b.HasIndex("userId");

                    b.ToTable("favourites");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Notify", b =>
                {
                    b.Property<long>("notifyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("notifyId"));

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("postId")
                        .HasColumnType("bigint");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("notifyId");

                    b.HasIndex("postId");

                    b.HasIndex("userId");

                    b.ToTable("notifies");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Post", b =>
                {
                    b.Property<long>("postId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("postId"));

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("area")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageUrls")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("typeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("updatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("postId");

                    b.HasIndex("typeId");

                    b.HasIndex("userId");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Role", b =>
                {
                    b.Property<long>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("roleId"));

                    b.Property<string>("roleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Type", b =>
                {
                    b.Property<long?>("typeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("typeId"));

                    b.Property<string>("typeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("typeId");

                    b.ToTable("types");
                });

            modelBuilder.Entity("Btl_web_nc.Models.User", b =>
                {
                    b.Property<long>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("userId"));

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("roleId")
                        .HasColumnType("bigint");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.HasIndex("roleId");

                    b.ToTable("users ");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Favourite", b =>
                {
                    b.HasOne("Btl_web_nc.Models.Post", "Post")
                        .WithMany("Favourites")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Btl_web_nc.Models.User", "User")
                        .WithMany("Favourites")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Notify", b =>
                {
                    b.HasOne("Btl_web_nc.Models.Post", "Post")
                        .WithMany("Notifies")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Btl_web_nc.Models.User", "User")
                        .WithMany("Notifies")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Post", b =>
                {
                    b.HasOne("Btl_web_nc.Models.Type", "Type")
                        .WithMany("Posts")
                        .HasForeignKey("typeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Btl_web_nc.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Btl_web_nc.Models.User", b =>
                {
                    b.HasOne("Btl_web_nc.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Post", b =>
                {
                    b.Navigation("Favourites");

                    b.Navigation("Notifies");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Btl_web_nc.Models.Type", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("Btl_web_nc.Models.User", b =>
                {
                    b.Navigation("Favourites");

                    b.Navigation("Notifies");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
