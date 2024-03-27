namespace animal_sounds;

public class Pig : IAnimal
{
    public string Name { get; set; }
    public string Sound { get; set; }
    
    public string MakeSound()
    {
        return $"Pig with the name {Name} makes sound: {Sound}";
    }
}