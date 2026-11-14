
Cat cat1 = new Cat(1, "Mingming", 2, "Available");
Cat cat2 = new Cat(2, "Snow", 1, "Under Care");

Console.WriteLine("=== CatCare 360 System ===");

// First cat
Console.WriteLine("\nCat 1: " + cat1.CatName);
Console.WriteLine("Adoption: " + cat1.Adopt());
Console.WriteLine("New Status: " + cat1.Status);

// Try adopting the same cat again
Console.WriteLine("\nTrying to adopt Mingming again...");
Console.WriteLine("Adoption: " + cat1.Adopt());

// Second cat
Console.WriteLine("\nCat 2: " + cat2.CatName);
Console.WriteLine("Adoption: " + cat2.Adopt());
Console.WriteLine("Current Status: " + cat2.Status);

// Update cat age
Console.WriteLine("\nUpdating Snow's age...");
Console.WriteLine("Update: " + cat2.UpdateAge(2));
Console.WriteLine("New Age: " + cat2.Age);

Console.WriteLine("\n=== End of CatCare 360 Test ===");