namespace animal_sounds;

public class Lion : IAnimal
{
    public string Name { get; set; }
    public string Sound { get; set; }

    public Lion(string name, string sound)
    {
        Name = name;
        Sound = sound;
    }
    
    public string MakeSound()
    {
        return $"Lion with the name {Name} makes sound: {Sound}";
    }
}