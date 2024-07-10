using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCovarianceContravariance.Intefaces
{
    internal interface IAnimalSound<out T> where T : IAnimal
    {
        void MakeSound();
    }
}
