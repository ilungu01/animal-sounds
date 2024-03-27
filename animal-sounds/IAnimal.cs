namespace animal_sounds;

public interface IAnimal
{
    string Name { get; set; }
    string Sound { get; set; }

    string MakeSound();
}