using System;

class Animal
{
    // Private attributes
    private string name;
    private string breed;
    private int age;

    // Constructor
    public Animal(string name, string breed, int age)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
    }

    // Setters
    public void SetName(string name) => Name = name;
    public void SetBreed(string breed) => Breed = breed;
    public void SetAge(int age) => Age = age;

    // Getters
    public string GetName() => Name;
    public string GetBreed() => Breed;
    public int GetAge() => Age;

    // Method
    public virtual void Bark()
    {
        Console.WriteLine("Animal sound!");
    }
}

class Dog : Animal
{
    // Private attribute
    private string favoriteToy;

    // Constructor
    public Dog(string name, string breed, int age, string favoriteToy)
        : base(name, breed, age)
    {
        this.favoriteToy = favoriteToy;
    }

    // Setter
    public void SetFavoriteToy(string favoriteToy)
    {
        this.favoriteToy = favoriteToy;
    }

    // Getter
    public string GetFavoriteToy()
    {
        return favoriteToy;
    }

    // Overridden method
    public override void Bark()
    {
        Console.WriteLine($"{GetName()} says: Woof! Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an Animal object
        Animal animal = new Animal("Generic Animal", "Unknown", 5);
        animal.SetName("Trex");
        animal.SetBreed("Mixed");
        animal.SetAge(4);

        // Create a Dog object
        Dog dog = new Dog("Buddy", "Golden Retriever", 3, "Ball");
        dog.SetName("Buddy");
        dog.SetBreed("Golden Retriever");
        dog.SetAge(3);
        dog.SetFavoriteToy("Ball");

        // Call Bark() method for both objects
        animal.Bark(); // Output: Animal sound!
        dog.Bark();    // Output: Buddy says: Woof! Woof!

        // Print attributes using getters
        Console.WriteLine($"Animal - Name: {animal.GetName()}, Breed: {animal.GetBreed()}, Age: {animal.GetAge()}");
        Console.WriteLine($"Dog - Name: {dog.GetName()}, Breed: {dog.GetBreed()}, Age: {dog.GetAge()}, Favorite Toy: {dog.GetFavoriteToy()}");
    }
}
