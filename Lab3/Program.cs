// PART 1

using Lab3;

Console.WriteLine("Enter Dog Name: ");
string dogName = Console.ReadLine();

Dog dog = new Dog(dogName, "Brown", 5);

Console.WriteLine($"\nDog Name: {dog.Name} \nColour:{dog.Colour} \nAge:{dog.Age}");
dog.Eat();

Console.WriteLine("\nEnter Cat Name: ");
string catName = Console.ReadLine();

Cat cat = new Cat(catName, "White", 10);

Console.WriteLine($"\nCat Name: {cat.Name} \nColour:{cat.Colour} \nAge:{cat.Age}");
cat.Eat();