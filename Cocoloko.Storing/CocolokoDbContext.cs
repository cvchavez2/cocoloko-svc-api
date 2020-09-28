using Cocoloko.Storing.Models;
using Microsoft.EntityFrameworkCore;

namespace Cocoloko.Storing
{
    public class CocolokoDbContext : DbContext
    {
        public DbSet<Beverage> Beverage { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        // public DbSet<BeverageIngredient> BeverageIngredient { get; set; }
        
        public CocolokoDbContext(DbContextOptions<CocolokoDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          // beverages
          modelBuilder.Entity<Beverage>().HasData(
            // beverage 1
            new Beverage
            {
              Id = 1,
              Name = "irish car bomb",
              Price = 8.5,
              ImageUrl = "http://placecorgi.com/260/180",
            },
            // beverage 2
            new Beverage
            {
              Id = 2,
              Name = "jaggerbomb",
              Price = 7.0,
              ImageUrl = "http://placecorgi.com/260/180",
            }
          );

          // ingredients
          modelBuilder.Entity<Ingredient>().HasData(
            // ingredient 1
            new Ingredient
            {
              Id = 1,
              Name = "baileys",
              Price = 1.50,
              BeverageId = 1
            },
            // ingredient 2
            new Ingredient
            {
              Id = 2,
              Name = "guinness",
              Price = 5.00,
              BeverageId = 1
            },
            // ingredient 3
            new Ingredient
            {
              Id = 3,
              Name = "jameson",
              Price = 2.00,
              BeverageId = 1
            },
            // ingredient 4
            new Ingredient
            {
              Id = 4,
              Name = "jagger",
              Price = 4.00,
              BeverageId = 2
            },
            // ingredient 5
            new Ingredient
            {
              Id = 5,
              Name = "red bull",
              Price = 3.00,
              BeverageId = 2
            }            
          );

          // // beverage-ingredient
          // modelBuilder.Entity<BeverageIngredient>().HasData(
          //   new BeverageIngredient
          //   {
          //     BeverageIngredientId = 1,
          //     BeverageId = 1,
          //     IngredientId = 1
          //   },
          //   new BeverageIngredient
          //   {
          //     BeverageIngredientId = 2,
          //     BeverageId = 1,
          //     IngredientId = 2
          //   },
          //   new BeverageIngredient
          //   {
          //     BeverageIngredientId = 3,
          //     BeverageId = 1,
          //     IngredientId = 3
          //   },
          //   new BeverageIngredient
          //   {
          //     BeverageIngredientId = 4,
          //     BeverageId = 2,
          //     IngredientId = 4
          //   },
          //   new BeverageIngredient
          //   {
          //     BeverageIngredientId = 5,
          //     BeverageId = 2,
          //     IngredientId = 5
          //   }            
          // );
        }
    }
}