﻿// <auto-generated />
using System;
using CalorieTrackingApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalorieTrackingApp.DAL.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20230923114651_initial3")]
    partial class initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfEntry")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionAnswer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SecurityQuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SecurityQuestionId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.ConsumedFood", b =>
                {
                    b.Property<int>("ConsumedFoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsumedFoodId"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<int>("ConsumedCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("ConsumedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.Property<int>("MealCategory")
                        .HasColumnType("int");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("Portion")
                        .HasColumnType("float");

                    b.HasKey("ConsumedFoodId");

                    b.HasIndex("AccountID");

                    b.HasIndex("FoodID");

                    b.ToTable("ConsumedFoods");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.ConsumedWater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Portion")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AccountID");

                    b.ToTable("ConsumedWaters");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("PortionCalorie")
                        .HasColumnType("float");

                    b.Property<double>("PortionCarb")
                        .HasColumnType("float");

                    b.Property<double>("PortionFat")
                        .HasColumnType("float");

                    b.Property<double>("PortionProtein")
                        .HasColumnType("float");

                    b.Property<double>("StandartPortion")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MealType = 2,
                            Name = "Köfte",
                            PortionCalorie = 300.0,
                            PortionCarb = 5.0,
                            PortionFat = 15.0,
                            PortionProtein = 25.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 2,
                            MealType = 9,
                            Name = "Pilav",
                            PortionCalorie = 250.0,
                            PortionCarb = 50.0,
                            PortionFat = 10.0,
                            PortionProtein = 5.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 3,
                            MealType = 1,
                            Name = "Salata",
                            PortionCalorie = 70.0,
                            PortionCarb = 10.0,
                            PortionFat = 5.0,
                            PortionProtein = 2.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 4,
                            MealType = 4,
                            Name = "Balık",
                            PortionCalorie = 200.0,
                            PortionCarb = 0.0,
                            PortionFat = 10.0,
                            PortionProtein = 20.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 5,
                            MealType = 10,
                            Name = "Pasta",
                            PortionCalorie = 350.0,
                            PortionCarb = 40.0,
                            PortionFat = 15.0,
                            PortionProtein = 10.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 6,
                            MealType = 7,
                            Name = "Çorba",
                            PortionCalorie = 120.0,
                            PortionCarb = 15.0,
                            PortionFat = 5.0,
                            PortionProtein = 5.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 7,
                            MealType = 0,
                            Name = "Elma",
                            PortionCalorie = 52.0,
                            PortionCarb = 13.0,
                            PortionFat = 0.20000000000000001,
                            PortionProtein = 0.5,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 8,
                            MealType = 0,
                            Name = "Muz",
                            PortionCalorie = 105.0,
                            PortionCarb = 27.0,
                            PortionFat = 0.29999999999999999,
                            PortionProtein = 1.1000000000000001,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 9,
                            MealType = 3,
                            Name = "Tavuk",
                            PortionCalorie = 165.0,
                            PortionCarb = 0.0,
                            PortionFat = 3.6000000000000001,
                            PortionProtein = 32.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 10,
                            MealType = 4,
                            Name = "Somon",
                            PortionCalorie = 206.0,
                            PortionCarb = 0.0,
                            PortionFat = 13.0,
                            PortionProtein = 20.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 11,
                            MealType = 1,
                            Name = "Karnabahar",
                            PortionCalorie = 25.0,
                            PortionCarb = 5.0,
                            PortionFat = 0.5,
                            PortionProtein = 2.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 12,
                            MealType = 2,
                            Name = "Tavuk Kebabı",
                            PortionCalorie = 176.0,
                            PortionCarb = 0.5,
                            PortionFat = 4.0999999999999996,
                            PortionProtein = 32.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 13,
                            MealType = 11,
                            Name = "Makarna",
                            PortionCalorie = 371.0,
                            PortionCarb = 71.0,
                            PortionFat = 1.3,
                            PortionProtein = 12.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 14,
                            MealType = 5,
                            Name = "Baklava",
                            PortionCalorie = 509.0,
                            PortionCarb = 65.0,
                            PortionFat = 40.0,
                            PortionProtein = 5.4000000000000004,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 15,
                            MealType = 5,
                            Name = "Çikolata",
                            PortionCalorie = 546.0,
                            PortionCarb = 60.0,
                            PortionFat = 29.0,
                            PortionProtein = 5.5,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 16,
                            MealType = 6,
                            Name = "Yumurta",
                            PortionCalorie = 155.0,
                            PortionCarb = 1.1000000000000001,
                            PortionFat = 11.0,
                            PortionProtein = 13.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 17,
                            MealType = 6,
                            Name = "Cips",
                            PortionCalorie = 536.0,
                            PortionCarb = 49.0,
                            PortionFat = 37.0,
                            PortionProtein = 6.7000000000000002,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 18,
                            MealType = 1,
                            Name = "Brokoli",
                            PortionCalorie = 55.0,
                            PortionCarb = 11.0,
                            PortionFat = 0.59999999999999998,
                            PortionProtein = 2.7999999999999998,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 19,
                            MealType = 0,
                            Name = "Portakal",
                            PortionCalorie = 43.0,
                            PortionCarb = 8.3000000000000007,
                            PortionFat = 0.20000000000000001,
                            PortionProtein = 1.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 20,
                            MealType = 3,
                            Name = "Hindi",
                            PortionCalorie = 135.0,
                            PortionCarb = 0.0,
                            PortionFat = 1.5,
                            PortionProtein = 29.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 21,
                            MealType = 4,
                            Name = "Karides",
                            PortionCalorie = 85.0,
                            PortionCarb = 0.0,
                            PortionFat = 0.90000000000000002,
                            PortionProtein = 20.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 22,
                            MealType = 2,
                            Name = "Sote",
                            PortionCalorie = 280.0,
                            PortionCarb = 4.0,
                            PortionFat = 13.0,
                            PortionProtein = 27.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 23,
                            MealType = 11,
                            Name = "Pizza",
                            PortionCalorie = 266.0,
                            PortionCarb = 32.0,
                            PortionFat = 11.0,
                            PortionProtein = 12.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 24,
                            MealType = 5,
                            Name = "Puding",
                            PortionCalorie = 127.0,
                            PortionCarb = 22.0,
                            PortionFat = 3.6000000000000001,
                            PortionProtein = 2.7000000000000002,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 25,
                            MealType = 8,
                            Name = "Kola",
                            PortionCalorie = 45.0,
                            PortionCarb = 11.0,
                            PortionFat = 0.0,
                            PortionProtein = 0.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 26,
                            MealType = 8,
                            Name = "Çay",
                            PortionCalorie = 1.0,
                            PortionCarb = 0.0,
                            PortionFat = 0.0,
                            PortionProtein = 0.10000000000000001,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 27,
                            MealType = 0,
                            Name = "Meyve Salatası",
                            PortionCalorie = 56.0,
                            PortionCarb = 14.0,
                            PortionFat = 0.10000000000000001,
                            PortionProtein = 0.90000000000000002,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 28,
                            MealType = 1,
                            Name = "Pancar Salatası",
                            PortionCalorie = 43.0,
                            PortionCarb = 9.5999999999999996,
                            PortionFat = 0.20000000000000001,
                            PortionProtein = 1.6000000000000001,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 29,
                            MealType = 3,
                            Name = "Fırın Tavuk",
                            PortionCalorie = 135.0,
                            PortionCarb = 0.0,
                            PortionFat = 3.6000000000000001,
                            PortionProtein = 23.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 30,
                            MealType = 4,
                            Name = "Levrek",
                            PortionCalorie = 167.0,
                            PortionCarb = 0.0,
                            PortionFat = 9.0,
                            PortionProtein = 20.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 31,
                            MealType = 1,
                            Name = "Mantar Sote",
                            PortionCalorie = 36.0,
                            PortionCarb = 4.9000000000000004,
                            PortionFat = 1.8,
                            PortionProtein = 3.1000000000000001,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 32,
                            MealType = 0,
                            Name = "Mango",
                            PortionCalorie = 60.0,
                            PortionCarb = 14.0,
                            PortionFat = 0.59999999999999998,
                            PortionProtein = 0.80000000000000004,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 33,
                            MealType = 2,
                            Name = "Kuzu Şiş",
                            PortionCalorie = 151.0,
                            PortionCarb = 0.0,
                            PortionFat = 5.0,
                            PortionProtein = 25.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 34,
                            MealType = 1,
                            Name = "Roka Salatası",
                            PortionCalorie = 19.0,
                            PortionCarb = 2.2000000000000002,
                            PortionFat = 0.29999999999999999,
                            PortionProtein = 2.8999999999999999,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 35,
                            MealType = 3,
                            Name = "Tavuk Salatası",
                            PortionCalorie = 188.0,
                            PortionCarb = 3.0,
                            PortionFat = 6.0,
                            PortionProtein = 28.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 36,
                            MealType = 4,
                            Name = "Karides Güveç",
                            PortionCalorie = 125.0,
                            PortionCarb = 5.0,
                            PortionFat = 5.0,
                            PortionProtein = 15.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 37,
                            MealType = 2,
                            Name = "Kuzu Tandır",
                            PortionCalorie = 325.0,
                            PortionCarb = 0.0,
                            PortionFat = 19.0,
                            PortionProtein = 32.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 38,
                            MealType = 11,
                            Name = "Pasta Salatası",
                            PortionCalorie = 160.0,
                            PortionCarb = 21.0,
                            PortionFat = 8.0,
                            PortionProtein = 2.7999999999999998,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 39,
                            MealType = 5,
                            Name = "Cheesecake",
                            PortionCalorie = 321.0,
                            PortionCarb = 19.0,
                            PortionFat = 26.0,
                            PortionProtein = 6.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 40,
                            MealType = 6,
                            Name = "Kumpir",
                            PortionCalorie = 242.0,
                            PortionCarb = 33.0,
                            PortionFat = 12.0,
                            PortionProtein = 5.7000000000000002,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 41,
                            MealType = 2,
                            Name = "Karnıyarık",
                            PortionCalorie = 224.0,
                            PortionCarb = 16.0,
                            PortionFat = 16.0,
                            PortionProtein = 5.4000000000000004,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 42,
                            MealType = 1,
                            Name = "Kısır",
                            PortionCalorie = 130.0,
                            PortionCarb = 21.0,
                            PortionFat = 2.0,
                            PortionProtein = 5.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 43,
                            MealType = 5,
                            Name = "Dondurma",
                            PortionCalorie = 178.0,
                            PortionCarb = 20.0,
                            PortionFat = 7.2999999999999998,
                            PortionProtein = 3.6000000000000001,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 44,
                            MealType = 8,
                            Name = "Soda",
                            PortionCalorie = 45.0,
                            PortionCarb = 11.0,
                            PortionFat = 0.0,
                            PortionProtein = 0.0,
                            StandartPortion = 100.0
                        },
                        new
                        {
                            Id = 45,
                            MealType = 8,
                            Name = "Su",
                            PortionCalorie = 0.0,
                            PortionCarb = 0.0,
                            PortionFat = 0.0,
                            PortionProtein = 0.0,
                            StandartPortion = 100.0
                        });
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.LikedAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("SocialMediaPostId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SocialMediaPostId");

                    b.ToTable("LikedAccounts");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SecurityQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("QestionText")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.ToTable("SecurityQuestions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            QestionText = "En sevdiğiniz yemek nedir?"
                        },
                        new
                        {
                            Id = 2,
                            QestionText = "İlk evcil hayvanınızın adı nedir?"
                        },
                        new
                        {
                            Id = 3,
                            QestionText = "En sevdiğiniz spor nedir?"
                        },
                        new
                        {
                            Id = 4,
                            QestionText = "Hangi şehirde doğdunuz?"
                        },
                        new
                        {
                            Id = 5,
                            QestionText = "En sevdiğiniz çocukluk arkadaşınızın adı nedir?"
                        },
                        new
                        {
                            Id = 6,
                            QestionText = "Hangi okulda ilk kez öğrenim gördünüz?"
                        },
                        new
                        {
                            Id = 7,
                            QestionText = "En sevdiğiniz hayvan nedir?"
                        });
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SocialMediaPost", b =>
                {
                    b.Property<int>("SocialMediaPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocialMediaPostId"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("LikeCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostDescription")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<byte[]>("PostPicture")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("SocialMediaPostId");

                    b.HasIndex("AccountId");

                    b.ToTable("SocialMediaPosts");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.UserDetail", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<double>("BMI")
                        .HasColumnType("float");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ExerciseLevel")
                        .HasColumnType("float");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<double>("LastWeight")
                        .HasColumnType("float");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("TargetCalorieIntake")
                        .HasColumnType("float");

                    b.Property<double>("TargetWaterIntake")
                        .HasColumnType("float");

                    b.Property<double>("TargetWeight")
                        .HasColumnType("float");

                    b.HasKey("AccountId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.WeightHistory", b =>
                {
                    b.Property<int>("WeightHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeightHistoryId"), 1L, 1);

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<DateTime>("WeightDate")
                        .HasColumnType("datetime2");

                    b.HasKey("WeightHistoryId");

                    b.HasIndex("AccountID");

                    b.ToTable("WeightHistories");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Account", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.SecurityQuestion", "SecurityQuestion")
                        .WithMany("Accounts")
                        .HasForeignKey("SecurityQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SecurityQuestion");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.ConsumedFood", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithMany("ConsumedFoods")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalorieTrackingApp.DATA.Entities.Food", "Food")
                        .WithMany("ConsumedFoods")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.ConsumedWater", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithMany("ConsumedWaters")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.LikedAccount", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.SocialMediaPost", "SocialMediaPost")
                        .WithMany("LikedAccounts")
                        .HasForeignKey("SocialMediaPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SocialMediaPost");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SocialMediaPost", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithMany("SocialMediaPosts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.UserDetail", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithOne("UserDetail")
                        .HasForeignKey("CalorieTrackingApp.DATA.Entities.UserDetail", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.WeightHistory", b =>
                {
                    b.HasOne("CalorieTrackingApp.DATA.Entities.Account", "Account")
                        .WithMany("WeightHistories")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Account", b =>
                {
                    b.Navigation("ConsumedFoods");

                    b.Navigation("ConsumedWaters");

                    b.Navigation("SocialMediaPosts");

                    b.Navigation("UserDetail")
                        .IsRequired();

                    b.Navigation("WeightHistories");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.Food", b =>
                {
                    b.Navigation("ConsumedFoods");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SecurityQuestion", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("CalorieTrackingApp.DATA.Entities.SocialMediaPost", b =>
                {
                    b.Navigation("LikedAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}