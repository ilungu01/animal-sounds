namespace animal_sounds;

public class Dog : IAnimal
{
    public string Name { get; set; }
    public string Sound { get; set; }

    public Dog(string name, string sound)
    {
        Name = name;
        Sound = sound;
    }

    public string MakeSound()
    {
        return $"Dog with the name {Name} makes sound: {Sound}";
    }
}