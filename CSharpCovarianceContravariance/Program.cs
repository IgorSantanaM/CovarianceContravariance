using CSharpCovarianceContravariance.Intefaces;
using CSharpCovarianceContravariance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCovarianceContravariance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Covariance example
            IDog dog = new Dog("Buddy");
            IAnimalSound<IAnimal> animalSound = new AnimalSound<IDog>(dog);
            animalSound.MakeSound();

            ICat cat = new Cat("Whiskers");
            animalSound = new AnimalSound<ICat>(cat);
            animalSound.MakeSound();

            // Contravariance example
            IMakeSound<IDog> dogSound = new SoundPerformer<IAnimal>();
            dogSound.PerformSound(dog);

            IMakeSound<ICat> catSound = new SoundPerformer<IAnimal>();
            catSound.PerformSound(cat);
        }
    }

}
