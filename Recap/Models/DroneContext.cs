using Microsoft.EntityFrameworkCore;
using System;
using Procducts.Models;

public class DroneContext : DbContext
{
	public DbSet<Drone> Drones { get; set; }
	public DroneContext()
	{
		Database.EnsureDeleted();
		Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseMySQL("server=localhost;database=Drone;user=root;password=0000");
	}
}
