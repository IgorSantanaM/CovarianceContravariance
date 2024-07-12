using CSharpCovarianceContravariance.Intefaces;
namespace CSharpCovarianceContravariance
{
    public class SoundPerformer<T> : IMakeSound<T> where T : IAnimal
    {
        public void PerformSound(T animal)
        {
            if (animal is IDog)
            {
                Console.WriteLine($"Performing sound for dog named {animal.Name}");
                ((IDog)animal).Bark();
            }
            else if (animal is ICat)
            {
                Console.WriteLine($"Performing sound for cat named {animal.Name}");
                ((ICat)animal).Meow();
            }
            else
            {   
                throw new NotSupportedException("Unknown animal type.");
            }
        }
    }
}
