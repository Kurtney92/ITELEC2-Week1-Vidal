
Dog dog1 = new Dog(1, "Bantay", 3, "Available");
Dog dog2 = new Dog(2, "Brownie", 2, "Under Care");

Console.WriteLine("=== DogCare 360 System ===");

// First dog
Console.WriteLine("\nDog 1: " + dog1.DogName);
Console.WriteLine("Adoption: " + dog1.Adopt());
Console.WriteLine("New Status: " + dog1.Status);

// Try adopting the same dog again
Console.WriteLine("\nTrying to adopt Bantay again...");
Console.WriteLine("Adoption: " + dog1.Adopt());

// Second dog
Console.WriteLine("\nDog 2: " + dog2.DogName);
Console.WriteLine("Adoption: " + dog2.Adopt());
Console.WriteLine("Current Status: " + dog2.Status);

// Update dog's age
Console.WriteLine("\nUpdating Brownie's age...");
Console.WriteLine("Update: " + dog2.UpdateAge(3));
Console.WriteLine("New Age: " + dog2.Age);

Console.WriteLine("\n=== End of DogCare 360 Test ===");
