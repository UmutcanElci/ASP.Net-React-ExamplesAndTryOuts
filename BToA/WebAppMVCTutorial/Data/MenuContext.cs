using Microsoft.EntityFrameworkCore;
using WebAppMVCTutorial.Models;


namespace WebAppMVCTutorial.Data;

public class MenuContext : DbContext
{
    public MenuContext(DbContextOptions<MenuContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DishIngredient>().HasKey(di => new { di.DishId, di.IngredientId });
        
        modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
        modelBuilder.Entity<DishIngredient>().HasOne(d => d.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(d => d.IngredientId);
        
        modelBuilder.Entity<Dish>().HasData(
            new Dish{DishId = 1, Name = "Margherita",price = 7.50,ImageUrl = "https://i20.haber7.net/resize/1300x788//haber/haber7/photos/2022/32/en_kolay_margarita_pizza_nasil_yapilir_margarita_yapmanin_puf_noktalari_1660292423_6734.jpg"});
        
        modelBuilder.Entity<Ingredient>().HasData(
            new Ingredient{Id = 1, Name = "Tomato Sauce"},
            new Ingredient{Id = 2, Name = "Cheese"}
            );

        modelBuilder.Entity<DishIngredient>().HasData(
            new DishIngredient{DishId = 1, IngredientId = 1},
            new DishIngredient{DishId = 1, IngredientId = 2}
        );
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<DishIngredient> DishIngredients { get; set; }
}