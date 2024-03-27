namespace animal_sounds;

public class Lion : IAnimal
{
    public string Name { get; set; }
    public string Sound { get; set; }
    
    public string MakeSound()
    {
        return $"Lion with the name {Name} makes sound: {Sound}";
    }
}