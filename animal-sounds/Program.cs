using animal_sounds;

Cat cat = new Cat();
cat.Name = "Vasile";
cat.Sound = "Meow";

Pig pig = new Pig("Piggy");
pig.Sound = "Weee";

List<IAnimal> animals = new List<IAnimal>
{
    cat,
    pig,
    new Dog("Doggo","Wuf"),
    new Lion("Big boy", "Rawr")
};

foreach (var animal in animals)
{
    Console.WriteLine(animal.MakeSound());
}