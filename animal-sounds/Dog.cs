namespace animal_sounds;

public class Dog : IAnimal
{
    public string Name { get; set; }
    public string Sound { get; set; }
    public string MakeSound()
    {
        return $"Dog with the name {Name} makes sound: {Sound}";
    }
}