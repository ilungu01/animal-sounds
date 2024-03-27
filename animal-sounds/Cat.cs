namespace animal_sounds;

public class Cat : IAnimal
{
    public string Name { get; set; }
    public string Sound { get; set; }
    
    public string MakeSound()
    {
        return $"Cat with the name {Name} makes sound: {Sound}";
    }
}