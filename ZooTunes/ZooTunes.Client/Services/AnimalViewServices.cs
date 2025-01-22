using ZooTunes.Client.Model;

namespace ZooTunes.Client.Services;

public class AnimalViewServices
{
    public List<AnimalView> AnimalViews = [
    new AnimalView()
    {
         Name = "Elefant",
         ScienceName = "Elephantidae",
         IsFavorite = false,
         ImageUrl = "elephant/cover.png",
         AudioUrl = "",
         Info = "<DIALOGINFO>",
    }];
}