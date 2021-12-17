using Interface;
using System;

namespace Interface
{
    public class Program
    {
        public void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound" );
        }
    }
}
 class Dog : animal 
{
    public void AnimalSound()
    {
        Console.WriteLine("The dog says : hauv hauv");
    }
}
class Cat : animal
{
    public void AnimalSound()
    {
        Console.WriteLine("The cat says : mau mau");
    }
}