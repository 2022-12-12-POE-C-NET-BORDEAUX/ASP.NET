using Microsoft.EntityFrameworkCore;
using System;
using Products.Models;

public class DroneContext : DbContext
{
	public DbSet<Drone> Drones { get; set; }
	public DbSet<Liaison> Liaisons { get; set; }
	public DbSet<User> Users { get; set; }
	public DroneContext()
	{
		Database.EnsureDeleted();
		Database.EnsureCreated();
		Drones.Add(new Drone("Drone 1", "Description 1"));
		Drones.Add(new Drone("Drone 2", "Description 2"));
		Users.Add(new User("User 1"));
		Users.Add(new User("User 2"));
		SaveChanges();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySQL("server=localhost;database=Drone;user=root;password=0000");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Liaison>().HasKey(e => new { e.UserId, e.DroneId });
	}
}
