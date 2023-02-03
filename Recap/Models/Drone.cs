namespace Procducts.Models
{
	public class Drone
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public Drone()
		{
		}

		public Drone(string name, string description)
		{
			Name = name;
			Description = description;
		}
	}

}
