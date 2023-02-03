using Microsoft.EntityFrameworkCore;
using System;
using Procducts.Models;

public class DroneContext : DbContext
{
	public DbSet<Drone> Drones { get; set; }
	public DbSet<User> Users { get; set; }
	public DroneContext()
	{
		Database.EnsureDeleted();
		Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySQL("server=localhost;database=Drone;user=root;password=0000");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Drone>().HasOne(d => d.User).WithMany(u => u.Drones).HasForeignKey(d => d.UserId);
	}
}
