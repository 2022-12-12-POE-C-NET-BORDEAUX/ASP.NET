using Microsoft.AspNetCore.Mvc;
using Products.Models;
using System;

public class DroneController : Controller
{
	static public DroneContext context = new DroneContext();

	//static = sauvegarde de la donnee entre les creation de controller

	public DroneController()
	{
		//context = new DroneContext();
	}

	public IActionResult Index()
	{
		return View(context.Drones.ToList());
		// Drones -> Model
	}

	[HttpGet]
	public IActionResult Details(int id)
	{
		// Drone drone = ListeDrone.Find(d => d.Id == id);
		// 1 2 3 4 5 6 7 8 9 10
		// lamda renvoi true si jamais l'id du drone == id
		// liste de drone -> drone
		Drone drone = context.Drones.Find(id);
		return View(drone);// Model <= drone = drone a l'id passer en parametre
	}

	[HttpPost]//annotation
	public IActionResult Create(string name, string description)
	{
		Drone tmp = new Drone(name, description);
		context.Drones.Add(tmp);
		context.SaveChanges();
		return RedirectToAction("Index", "Home");
	}

	[HttpGet]
	public IActionResult Edit(int id)
	{
		Drone drone = context.Drones.Find(id);
		return View(drone);
	}

	[HttpPost]
	public IActionResult Edit(Drone drone)// Objet Drone <- id
	{
		Drone tmp = context.Drones.Find(drone.Id);
		tmp.Name = drone.Name;
		tmp.Description = drone.Description;
		context.SaveChanges();
		return RedirectToAction("Index", "Drone");
	}

	public IActionResult Create()
	{
		return View();
	}

	public IActionResult Delete(int id)
	{
		Drone drone = context.Drones.Find(id);
		context.Drones.Remove(drone);
		context.SaveChanges();
		return RedirectToAction("Index", "Drone");
	}
}
