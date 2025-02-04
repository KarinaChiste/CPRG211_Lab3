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

//PART 2
// Uses the classes Dog2 and Cat2

Console.WriteLine("\nEnter New Dog Name: ");
string dog2Name  = Console.ReadLine();
Dog2 dog2 = new Dog2(dog2Name);
Console.WriteLine("Enter Dog Colour: ");
dog2.Colour = Console.ReadLine();
Console.WriteLine("Enter Dog Height: ");
dog2.Height = Console.ReadLine();
Console.WriteLine("Enter Dog Age: ");
dog2.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nDog Name: {dog2.Name} \nDog Colour: {dog2.Colour} \nDog Height: {dog2.Height} \nDog Age: {dog2.Age}");
dog2.Eat();
Console.WriteLine(dog2.Cry());

Console.WriteLine("\nEnter New Cat Name: ");
string cat2Name = Console.ReadLine();
Cat2 cat2 = new Cat2(cat2Name);
Console.WriteLine("Enter Cat Colour: ");
cat2.Colour = Console.ReadLine();
Console.WriteLine("Enter Cat Height: ");
cat2.Height = Console.ReadLine();
Console.WriteLine("Enter Cat Age: ");
cat2.Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nCat Name: {cat2.Name} \nCat Colour: {cat2.Colour} \nCat Height: {cat2.Height} \nCat Age: {cat2.Age}");
cat2.Eat();
Console.WriteLine(cat2.Cry());

List<IAnimal> animals = new List<IAnimal>();

animals.Add(dog2);
animals.Add(cat2);
animals.Add(new Dog2("Buddy"));
animals.Add(new Cat2("Ravioli"));
animals.Add(new Cat2("Alfredo"));

Console.WriteLine("\nAnimal Names: ");
foreach(IAnimal animal in animals)
{
    Console.WriteLine(animal.Name);
}