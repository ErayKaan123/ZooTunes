namespace ZooTunes.Client.Animals;

public class AnimalData
{
    public string AnimalName { get; set; }
    public string Image { get; set; }
    public Dictionary<string, string> Sounds { get; set; }

    public AnimalData(string animalName, string image, Dictionary<string, string> sounds)
    {
        Sounds = sounds;
        AnimalName = animalName;
        Image = image;
    }
}