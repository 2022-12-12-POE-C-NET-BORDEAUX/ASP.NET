namespace Products.Models
{
	public class Drone
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<Liaison> Liaisons { get; set; }


		public Drone()
		{
		}

		public Drone(string name, string description)
		{
			Name = name;
			Description = description;
		}
	}


	public class Liaison
	{
		public int UserId { get; set; }
		public int DroneId { get; set; }

		public User User { get; set; }
		public Drone Drone { get; set; }

		public Liaison()
		{

		}
	}

	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Liaison> Liaisons { get; set; }

		public User()
		{
		}

		public User(string name)
		{
			this.Name = name;
		}
	}
}
