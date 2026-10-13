using Microsoft.EntityFrameworkCore;
using Trainings_Logger.Models;

namespace Trainings_Logger.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Exercise> Exercises => Set<Exercise>();
    public DbSet<Workout> Workouts => Set<Workout>();
    public DbSet<WorkoutSet> Sets => Set<WorkoutSet>();
}