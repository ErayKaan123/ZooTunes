namespace ZooTunes.Client.Animals;

public class AnimalData(
    string animalName,
    string image,
    Dictionary<string, string> sounds,
    string scientificName = "",
    bool isFavorite = false,
    string description = "")
{
    public string AnimalName { get; set; } = animalName;
    public string ScienetificName { get; set; } = scientificName;
    public bool IsFavorite { get; set; } = isFavorite;
    public string Description { get; set; } = description;
    public string Image { get; set; } = image;
    public Dictionary<string, string> Sounds { get; set; } = sounds;
}