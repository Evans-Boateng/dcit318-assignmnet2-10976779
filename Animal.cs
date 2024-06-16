public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

public static void Main(string[] args)
{
    Animal animal = new Animal();
    Dog dog = new Dog();
    Cat cat = new Cat();

    animal.MakeSound(); // Prints "Some generic sound"
    dog.MakeSound();   // Prints "Bark"
    cat.MakeSound();   // Prints "Meow"
}