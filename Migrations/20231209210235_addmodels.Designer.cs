﻿// <auto-generated />
using System;
using FoodRecipe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodRecipe.Migrations
{
    [DbContext(typeof(FoodDbContaxt))]
    [Migration("20231209210235_addmodels")]
    partial class addmodels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryRecipe", b =>
                {
                    b.Property<int>("CategoriesCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("RecipesRecipeID")
                        .HasColumnType("int");

                    b.HasKey("CategoriesCategoryID", "RecipesRecipeID");

                    b.HasIndex("RecipesRecipeID");

                    b.ToTable("CategoryRecipe");
                });

            modelBuilder.Entity("FoodRecipe.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1bfada60-16c2-414c-8220-d22503282256",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f8c8b357-fd41-40a4-91d6-0cdcb0edc640",
                            TwoFactorEnabled = false,
                            UserName = "user1@example.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "58d67804-deea-4be6-a00f-da18bf33f4bb",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "da0ddd4d-727f-42ce-acad-53254de4a958",
                            TwoFactorEnabled = false,
                            UserName = "user2@example.com"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "149c10c1-7dc1-4f2c-abb8-7b8c289e6445",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "37cbb7e4-62eb-46c4-be0f-149050c3daa5",
                            TwoFactorEnabled = false,
                            UserName = "user3@example.com"
                        });
                });

            modelBuilder.Entity("FoodRecipe.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            Name = "Breakfast"
                        },
                        new
                        {
                            CategoryID = 2,
                            Name = "Pasta"
                        },
                        new
                        {
                            CategoryID = 3,
                            Name = "Chicken Dishes"
                        });
                });

            modelBuilder.Entity("FoodRecipe.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CommentId");

                    b.HasIndex("RecipeID");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("FoodRecipe.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IngredientID");

                    b.HasIndex("UserId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientID = 1,
                            Name = "Flour"
                        },
                        new
                        {
                            IngredientID = 2,
                            Name = "Eggs"
                        },
                        new
                        {
                            IngredientID = 3,
                            Name = "Chicken Breast"
                        });
                });

            modelBuilder.Entity("FoodRecipe.Models.Like", b =>
                {
                    b.Property<int>("LikeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LikeId"));

                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LikeId");

                    b.HasIndex("RecipeID");

                    b.HasIndex("UserId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("FoodRecipe.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecipeID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Steps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipeID");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeID = 1,
                            Description = "A simple and delicious pancake recipe.",
                            Steps = "1. Mix flour, sugar, and baking powder. 2. Add milk and eggs. 3. Cook on a hot griddle.",
                            Title = "Classic Pancakes"
                        },
                        new
                        {
                            RecipeID = 2,
                            Description = "Traditional Italian pasta dish with meat sauce.",
                            Steps = "1. Cook pasta. 2. Prepare meat sauce. 3. Combine pasta and sauce.",
                            Title = "Spaghetti Bolognese"
                        },
                        new
                        {
                            RecipeID = 3,
                            Description = "Quick and easy chicken stir-fry recipe.",
                            Steps = "1. Marinate chicken. 2. Stir-fry vegetables and chicken. 3. Serve over rice.",
                            Title = "Chicken Stir Fry"
                        });
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.Property<int>("IngredientsIngredientID")
                        .HasColumnType("int");

                    b.Property<int>("RecipesRecipeID")
                        .HasColumnType("int");

                    b.HasKey("IngredientsIngredientID", "RecipesRecipeID");

                    b.HasIndex("RecipesRecipeID");

                    b.ToTable("IngredientRecipe");
                });

            modelBuilder.Entity("CategoryRecipe", b =>
                {
                    b.HasOne("FoodRecipe.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodRecipe.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesRecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodRecipe.Models.Comment", b =>
                {
                    b.HasOne("FoodRecipe.Models.Recipe", "Recipe")
                        .WithMany("Comments")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodRecipe.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodRecipe.Models.Ingredient", b =>
                {
                    b.HasOne("FoodRecipe.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FoodRecipe.Models.Like", b =>
                {
                    b.HasOne("FoodRecipe.Models.Recipe", "Recipe")
                        .WithMany("Likes")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodRecipe.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IngredientRecipe", b =>
                {
                    b.HasOne("FoodRecipe.Models.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsIngredientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodRecipe.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesRecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FoodRecipe.Models.Recipe", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}