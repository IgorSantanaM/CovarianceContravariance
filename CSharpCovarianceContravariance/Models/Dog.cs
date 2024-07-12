using CSharpCovarianceContravariance.Intefaces;

public class Dog : IDog
{
    public string Name { get; }

    public Dog(string name)
    {
        Name = name;
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}