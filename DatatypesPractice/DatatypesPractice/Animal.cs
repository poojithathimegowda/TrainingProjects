namespace DatatypesPractice
{
    public  class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public virtual void AnimalsSound()
        {
            Console.WriteLine("hello");
        }

        //public List<Animal> animals = new List<Animal>();

        //public void AddAnimal(Animal animal)
        //{
        //    animals.Add(animal);
        //}
        //public virtual void ToPrintAllTheAnimals()
        //{
        //    foreach (var animal in animals)
        //    {
        //        Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
                
        //    }
        //}
    }
    //public class Dogs : Animal
    //{

    //    public override void AnimalsSound()
    //    {
    //        Console.WriteLine("Dogs says baw baw");
    //    }
    //}
    //public class Cats : Animal
    //{

    //    public override void AnimalsSound()
    //    {
    //        Console.WriteLine("cats saw meow meow");
    //    }
    //}
    public class Reptiles: Animal { }
    public class Mammal : Animal { }
    public class Lizard: Reptiles { }
}
