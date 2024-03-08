using MealPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace MealPlanner.Database;

public class MealPlannerContext(DbContextOptions<MealPlannerContext> options) : DbContext(options)
{
    public DbSet<Recipe> Recipes { get; set; }
}
