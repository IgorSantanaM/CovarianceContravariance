using CSharpCovarianceContravariance.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCovarianceContravariance
{
    public class AnimalSound<T> : IAnimalSound<T> where T : IAnimal
    {
        private readonly T animal;

        public AnimalSound(T animal)
        {
            this.animal = animal;
        }

        public void MakeSound()
        {
            if (animal is IDog)
            {
                ((IDog)animal).Bark();
            }
            else if (animal is ICat)
            {
                ((ICat)animal).Meow();
            }
            else
            {
                throw new NotSupportedException("Unknown animal type.");
            }
        }
    }
}
