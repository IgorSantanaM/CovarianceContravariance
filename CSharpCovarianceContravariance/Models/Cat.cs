using CSharpCovarianceContravariance.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCovarianceContravariance.Models
{
    public class Cat : ICat
    {
        public string Name { get; }

        public Cat(string name)
        {
            Name = name;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
}
