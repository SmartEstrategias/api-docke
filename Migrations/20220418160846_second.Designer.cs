﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using newDockeNet.Data.Context;

#nullable disable

namespace newDockeNet.Migrations
{
    [DbContext(typeof(DockeContext))]
    [Migration("20220418160846_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("newDockeNet.Core.Models.CompanyModel", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cep")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cnpj")
                        .HasColumnType("TEXT");

                    b.Property<string>("Complement")
                        .HasColumnType("TEXT");

                    b.Property<string>("District")
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Logo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumberAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("newDockeNet.Core.Models.DPOModel", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Branchline")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cellphone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Job")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("DPOs");
                });

            modelBuilder.Entity("newDockeNet.Core.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DPOId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("updatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("newDockeNet.Core.Models.CompanyModel", b =>
                {
                    b.HasOne("newDockeNet.Core.Models.UserModel", "User")
                        .WithOne("Company")
                        .HasForeignKey("newDockeNet.Core.Models.CompanyModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("newDockeNet.Core.Models.DPOModel", b =>
                {
                    b.HasOne("newDockeNet.Core.Models.UserModel", "User")
                        .WithOne("DPO")
                        .HasForeignKey("newDockeNet.Core.Models.DPOModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("newDockeNet.Core.Models.UserModel", b =>
                {
                    b.Navigation("Company");

                    b.Navigation("DPO");
                });
#pragma warning restore 612, 618
        }
    }
}
