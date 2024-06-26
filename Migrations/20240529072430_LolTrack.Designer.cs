﻿// <auto-generated />
using System;
using LolTrack.EFDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LolTrack.Migrations
{
    [DbContext(typeof(LolDbContext))]
    [Migration("20240529072430_LolTrack")]
    partial class LolTrack
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LolTrack.Models.Ability", b =>
                {
                    b.Property<int>("AbiID")
                        .HasColumnType("int");

                    b.Property<int>("AbiChampID")
                        .HasColumnType("int");

                    b.Property<string>("AbilityDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AbilityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AbilitySplash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AbiID");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("LolTrack.Models.Champion", b =>
                {
                    b.Property<int>("ChampionID")
                        .HasColumnType("int");

                    b.Property<string>("ChampDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChampSplash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChampionID");

                    b.ToTable("Champions");
                });

            modelBuilder.Entity("LolTrack.Models.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<string>("ItemDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemValue")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("LolTrack.Models.Match", b =>
                {
                    b.Property<int>("MatchID")
                        .HasColumnType("int");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<string>("Champions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<string>("Items")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("KDA")
                        .HasColumnType("float");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<string>("LaneType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Minions")
                        .HasColumnType("int");

                    b.Property<int>("PlayerMatchID")
                        .HasColumnType("int");

                    b.Property<string>("SSpells")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("UserMatchID")
                        .HasColumnType("int");

                    b.Property<int>("Visionscore")
                        .HasColumnType("int");

                    b.Property<bool>("Win")
                        .HasColumnType("bit");

                    b.HasKey("MatchID");

                    b.HasIndex("UserID");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("LolTrack.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<double>("AvgVision")
                        .HasColumnType("float");

                    b.Property<double>("KDA")
                        .HasColumnType("float");

                    b.Property<string>("PlayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalLosses")
                        .HasColumnType("int");

                    b.Property<int>("TotalMatch")
                        .HasColumnType("int");

                    b.Property<int>("TotalWins")
                        .HasColumnType("int");

                    b.Property<double>("WinPerC")
                        .HasColumnType("float");

                    b.HasKey("PlayerID");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("LolTrack.Models.Rune", b =>
                {
                    b.Property<int>("RuneID")
                        .HasColumnType("int");

                    b.Property<string>("RuneDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RunePageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RuneID");

                    b.ToTable("Runes");
                });

            modelBuilder.Entity("LolTrack.Models.SSpell", b =>
                {
                    b.Property<int>("SSpellID")
                        .HasColumnType("int");

                    b.Property<string>("SSpellSplash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpellDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpellType")
                        .HasColumnType("int");

                    b.HasKey("SSpellID");

                    b.ToTable("SSpells");
                });

            modelBuilder.Entity("LolTrack.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileSplash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("UserPlayerID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LolTrack.Models.Match", b =>
                {
                    b.HasOne("LolTrack.Models.User", null)
                        .WithMany("Matches")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("LolTrack.Models.User", b =>
                {
                    b.Navigation("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}
