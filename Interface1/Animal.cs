using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{ 
    public abstract class animal
    {
        static void Main(string[] args)
        {
            animal animal = new animal();
            animal myAnimal = animal;
            animal myDog = new Dog();
            animal myCat = new Cat();

            myAnimal.animalSound();
            myDog.animalSound();
            myCat.animalSound();

        }

        private void animalSound()
        {
            throw new NotImplementedException();
        }

        private void AnimalSound()
        {
            throw new NotImplementedException();
        }
    }
}


 
