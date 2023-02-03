namespace Procducts.Models
{
	public class Drone
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }

		public Drone()
		{
		}

		public Drone(string name, string description, User user)
		{
			this.User = user;
			this.UserId = user.Id;
			this.Name = name;
			this.Description = description;
		}
	}

	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Drone> Drones { get; set; }

		public User()
		{
		}

		public User(string name)
		{
			this.Name = name;
		}
	}
}
