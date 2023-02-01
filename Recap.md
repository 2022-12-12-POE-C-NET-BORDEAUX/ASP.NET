# Recapitulatif du cours aspdotnet

1. Présentation de l'architecture MVC

---

Model : représente les données de l'application, par des classes C#.
View : représente la présentation des données, par des fichiers HTML.
Controller : représente le contrôleur de l'application, par des classes C# héritant de la classe Controller.

2. Création d'un projet MVC

bash : $ dotnet new mvc -o aspdotnet

3. Presentation de la structure d'un projet MVC

```
aspdotnet
├── aspdotnet.csproj
├── Controllers
│   └── HomeController.cs
├── Models
│   └── ErrorViewModel.cs
├── obj
│   ├── aspdotnet.csproj.nuget.cache
│   ├── aspdotnet.csproj.nuget.dgspec.json
│   ├── aspdotnet.csproj.nuget.g.props
│   ├── aspdotnet.csproj.nuget.g.targets
│   ├── project.assets.json
│   └── project.nuget.cache
├── Program.cs
├── Properties
│   └── launchSettings.json
├── Views
│   ├── Home
│   │   ├── About.cshtml
│   │   ├── Contact.cshtml
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
```

4. Création d'un controller

-   Création d'un controller
-   Création d'une action

```csharp
using Microsoft.AspNetCore.Mvc;

class HomeController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
}
```

5. Création d'une vue

-   Création d'une vue

```html
<!DOCTYPE html>
<html>
    <head>
        <title>Index</title>
    </head>
    <body>
        <h1>Index</h1>
    </body>
</html>
```

6. Création d'un model

-   Création d'un model

```csharp
using System;

class Person
{
	public string Name { get; set; }
	public string FirstName { get; set; }
	public DateTime BirthDate { get; set; }
}
```

===================================================

## Présentation de Razor

-   Razor est un moteur de template
    Il permet d'injecter du code C# dans des fichiers HTML

Exemple :

```html
@{ var person = new Person { Name = "Doe", FirstName = "John", BirthDate = new
DateTime(1980, 1, 1) }; }
```

```html
<!DOCTYPE html>
<html>
    <head>
        <title>Index</title>
    </head>
    <body>
        <h1>Index</h1>
        <p>Nom : @person.Name</p>
        <p>Prénom : @person.FirstName</p>
        <p>Date de naissance : @person.BirthDate</p>
    </body>
</html>
```

-   Presentation des conditions

```html
@if (person.BirthDate.Year > 2000) {
<p>Je suis né après 2000</p>
}
```

-   Presentation des boucles

```html
<ul>
    @foreach (var item in items) {
    <li>@item</li>
    }
</ul>
```

-   presentation des namespaces dans les vues

```csharp
@using aspdotnet.Models
```

-> dans le fichier cshtml \_ViewImports.cshtml

===================================================

Presentation des requêtes HTTP :

-   GET : récupération de données
-   POST : création de données

Création d'une View avec des données

-   Presentation de l'objet Model

Model : représente les données de l'application, par des classes C#.

```csharp
public IActionResult Index()
{
	var person = new Person
	{
		Name = "Doe",
		FirstName = "John",
		BirthDate = new DateTime(1980, 1, 1)
	};
	return View(person);
}
```

```html
<!DOCTYPE html>
<html>
    <head>
        <title>Index</title>
    </head>
    <body>
        <h1>Index</h1>
        <p>Nom : @Model.Name</p>
        <p>Prénom : @Model.FirstName</p>
        <p>Date de naissance : @Model.BirthDate</p>
    </body>
</html>
```

=====================================================

## Présentation des layouts

-   Qu'est-ce qu'un layout ?

Un layout est une vue qui contient le code HTML commun à plusieurs vues.
Elle permet de factoriser le code HTML commun à plusieurs vues.

-   Création d'un layout

```html
<!DOCTYPE html>
<html>
    <head>
        <title>@ViewData["Title"]</title>
    </head>
    <body>
        <h1>@ViewData["Title"]</h1>
        @RenderBody()
    </body>
</html>
```

-   Utilisation d'un layout

```html
@{ Layout = "_Layout";
```

=====================================================
