using ZooTunes.Client.Animals;

namespace ZooTunes.Client;

public static class AnimalDataRepository
{
    public static List<AnimalData> Data  =
        [
            new AnimalData(
                "African Lion Cub",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/landing-pages/animal-sounds/lion-cub_357x229.jpg?h=229&w=357&la=en&hash=BAF1DE0C2779C3D71B68D5BC0B8D3191",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/lion_2.wav?version=1_201811134822", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/lion_2.mp3?version=1_201811134817", "audio/mp3" }
                },
                scientificName: "Panthera leo",
                isFavorite: false,
                description: "The African lion cub is a playful and curious member of the Panthera leo species."
            ),

            new AnimalData(
                "Asian Elephant",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/landing-pages/animal-sounds/asian-elephant_357x229.jpg?h=229&w=357&la=en&hash=320FD8E4319A028BD5537BC2758A0715",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/elephant.wav?version=1_201811134825", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/elephant.mp3?version=1_201811134820", "audio/mp3" }
                },
                scientificName: "Elephas maximus",
                isFavorite: true,
                description: "The Asian elephant is known for its intelligence and strong social bonds."
            ),

            new AnimalData(
                "Bald Eagle",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/bgt-animals/2017_buschgardenstampabay_animals_baldeagle_357x229.jpg?h=229&w=357&la=en&hash=9F11264A958A9A0649B3EEA1935191AD",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/bald-eagle_2.wav?version=1_201811134821", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/bald-eagle_2.mp3?version=1_201811134822", "audio/mp3" }
                },
                scientificName: "Haliaeetus leucocephalus",
                isFavorite: false,
                description: "The bald eagle, a symbol of freedom, is found across North America."
            ),

            new AnimalData(
                "Bear",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/landing-pages/animal-sounds/cinnamon_bear_357x229.jpg?h=229&w=357&la=en&hash=743F4AD091BE2662727E0D6533A12203",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/bear.wav?version=1_201811134817", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/bear.mp3?version=1_201811134823", "audio/mp3" }
                },
                scientificName: "Ursidae",
                isFavorite: true,
                description: "Bears are powerful mammals found in diverse habitats around the world."
            ),

            new AnimalData(
                "Beluga Whale",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/beluga_whale_357x229.jpg?h=229&w=357&la=en&hash=20816DB612C9ADDAD89BCFFEAAA90C05",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/beluga-whale-001.mp3?version=1_201811135223", "audio/mp3" }
                },
                scientificName: "Delphinapterus leucas",
                isFavorite: false,
                description: "The beluga whale is a white, sociable marine mammal known for its distinctive rounded forehead and vocal abilities."
            ),


            new AnimalData(
                "Bengal Tiger",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/bengal_tiger_357x229.jpg?h=229&w=357&la=en&hash=D259836FFBCE04D6597C6BF09740313F",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/bengal_tiger.wav?version=1_201811134825", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/bengal_tiger.mp3?version=1_201811134819", "audio/mp3" }
                },
                scientificName: "Panthera tigris tigris",
                isFavorite: true,
                description: "The Bengal tiger is a large, striped predator native to the Indian subcontinent."
            ),


            new AnimalData(
                "Bottlenose Dolphin",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/bottlenose_dolphin_357x229.jpg?h=229&w=357&la=en&hash=D0A96FF68BA2FA94D06E7303A7C0A16B",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/bottlenose-dolphin/sound_dolphin_buzzing_clicks_ogg.ogg?version=1_201811061118", "audio/ogg" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/bottlenose-dolphin/sound_dolphin_buzzing_clicks_mp3.mp3?version=1_201811061117", "audio/mp3" }
                },
                scientificName: "Tursiops truncatus",
                isFavorite: false,
                description: "The bottlenose dolphin is an intelligent, social marine mammal known for its sleek body and playful behavior."
            ),


            new AnimalData(
                "California Sea Lion",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/california_sea_lion_357x229.jpg?h=229&w=357&la=en&hash=6BE84D112460425DB1B63D25C876DE57",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/sea_lion.wav?version=1_201811134816", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/sea_lion.mp3?version=1_201811134826", "audio/mp3" }
                },
                scientificName: "Zalophus californianuss",
                isFavorite: false,
                description: "The California sea lion is a fast, agile marine mammal known for its playful nature and loud barks."
            ),


            new AnimalData(
                "Chimpanzee",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/bgt-animals/2017_buschgardenstampabay_animals_chimps_357x229.jpg?h=229&w=357&la=en&hash=6F3F660DF3723B2516CF502C909A0373",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/chimp.wav?version=1_201811134826", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/chimp.mp3?version=1_201811134822", "audio/mp3" }
                },
                scientificName: "Pan troglodytes",
                isFavorite: false,
                description: "The chimpanzee is an intelligent primate known for its complex social behavior and problem-solving abilities."
            ),


            new AnimalData(
                "Cougar",
                "https://upload.wikimedia.org/wikipedia/commons/d/d6/Mountain_Lion_in_Glacier_National_Park.jpg",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/panther.wav?version=1_201811134823", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/panther.mp3?version=1_201811134817", "audio/mp3" }
                },
                scientificName: "Puma concolor",
                isFavorite: false,
                description: "The cougar is a large, solitary wild cat known for its strength, agility, and adaptability across various habitats."
            ),


            new AnimalData(
                "Dromedary Camel",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/dromedary_camel_357x229.jpg?h=229&w=357&la=en&hash=8C4E3E743BCEC48265E7F77ABEAED2E5",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/camel.wav?version=1_201811134822", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/camel.mp3?version=1_201811134821", "audio/mp3" }
                },
                scientificName: "Camelus dromedarius",
                isFavorite: true,
                description: "The dromedary camel is a desert animal known for its endurance and single hump."
            ),



            new AnimalData(
                "Eagle",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/landing-pages/animal-sounds/eagle_357x229.jpg?h=229&w=357&la=en&hash=0D042CC994124C9C34FE144FB4C22CAD",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/eagle_1.wav?version=1_201811134821", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/eagle_1.mp3?version=1_201811134821", "audio/mp3" }
                },
                scientificName: "Haliaeetus leucocephalus",
                isFavorite: true,
                description: "The eagle is a powerful bird of prey with sharp vision and strong wings."
            ),

            new AnimalData(
                "Falcon",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/landing-pages/animal-sounds/falcon_357x229.jpg?h=229&w=357&la=en&hash=2889505B9145748750A4CA6611EB09A3",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/falcon.wav?version=1_201811134818", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/falcon.mp3?version=1_201811134824", "audio/mp3" }
                },
                scientificName: "Falco peregrinus",
                isFavorite: false,
                description: "The falcon is a fast-flying bird known for its hunting skills."
            ),

            new AnimalData(
                "Florida Panther",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/florida_panther_357x229.jpg?h=229&w=357&la=en&hash=EA064FCDA8A04FA3E483B4D166385227",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/cougar.wav?version=1_201811134824", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/cougar.mp3?version=1_201811134819", "audio/mp3" }
                },
                scientificName: "Puma concolor coryi",
                isFavorite: true,
                description: "The Florida panther is a rare big cat known for its agility and stealth."
            ),

            new AnimalData(
                "Frog",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/landing-pages/animal-sounds/frog_357x229.jpg?h=229&w=357&la=en&hash=F1776257062667AB4FD9C6888EAB41DC",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/frog.wav?version=1_201811134824", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/frog.mp3?version=1_201811134820", "audio/mp3" }
                },
                scientificName: "Lithobates catesbeianus",
                isFavorite: false,
                description: "The frog is an amphibian known for its jumping ability and croaking sound."
            ),

            new AnimalData(
            "Giant Anteater",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/giant_anteater_357x229.jpg?h=229&w=357&la=en&hash=285D31026D48ACB07EA3236B6CC3E8F3",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/anteater.wav?version=1_201811134818", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/anteater.mp3?version=1_201811134825", "audio/mp3" }
                },
                scientificName: "Myrmecophaga tridactyla",
                isFavorite: true,
                description: "The giant anteater is a unique mammal known for its long snout and tongue."
            ),

            new AnimalData(
                "Gibbon",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/bgt-animals/2017_buschgardenstampabay_animals_gibbon_357x229.jpg?h=229&w=357&la=en&hash=4507C3D92E6A468807066962A5703EBB",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/gibbon.wav?version=1_201811134820", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/gibbon.mp3?version=1_201811134820", "audio/mp3" }
                },
                scientificName: "Hylobates lar",
                isFavorite: false,
                description: "The gibbon is an agile primate known for its loud calls and tree-swinging skills."
            ), 
            new AnimalData(
                "Gray Wolf",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/gray_wolf_357x229.jpg?h=229&w=357&la=en&hash=491313F9B34AD99E6E0C6A45696A0F8F",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/wolf.wav?version=1_201811134820", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/wolf.mp3?version=1_201811134825", "audio/mp3" }
                },
                scientificName: "Canis lupus",
                isFavorite: false,
                description: "The gray wolf is a powerful pack hunter known for its teamwork and endurance."
            ),
            new AnimalData(
                "Harbor Seal",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/harbor_seal_357x229.jpg?h=229&w=357&la=en&hash=CE897F5F47228259BA939DAA9E080C1E",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/harbor-seal-001.mp3?version=1_201811132301", "audio/mp3" }
                },
                scientificName: "Phoca vitulina",
                isFavorite: true,
                description: "The harbor seal is a sleek marine mammal known for its agility in water."
            ),
            new AnimalData(
                "Hippopotamus",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/bgt-animals/2017_buschgardenstampabay_animals_hippos4_357x229.jpg?h=229&w=357&la=en&hash=29492431CB3CC3C886E747FA6D1654AE",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/hippo.wav?version=1_201811134823", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/hippo.mp3?version=1_201811134818", "audio/mp3" }
                },
                scientificName: "Hippopotamus amphibius",
                isFavorite: false,
                description: "The hippopotamus is a large, semi-aquatic mammal known for its strength."
            ),
            new AnimalData(
                "Horse",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/infobooks/clydesdales/listing-images/clydesdale_37x229.jpg?h=229&w=357&la=en&hash=0C5E7E2B07B05C1C304B9F12ABECCC92",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/clydesdale.mp3?version=1_201811130506", "audio/mp3" }
                },
                scientificName: "Equus ferus caballus",
                isFavorite: true,
                description: "The horse is a strong and fast mammal domesticated for riding and work."
            ),
            new AnimalData(
                "Jaguar",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/jaguar_357x229.jpg?h=229&w=357&la=en&hash=CC00BF9399BF6296D1C28B661BA54056",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/jaguar.wav?version=1_201811134817", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/jaguar.mp3?version=1_201811134823", "audio/mp3" }
                },
                scientificName: "Panthera onca",
                isFavorite: false,
                description: "The jaguar is a powerful and stealthy big cat known for its strength and agility."
            ),
            new AnimalData(
                "Killer Whale",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/infobooks/killer-whales/listing-images/killer_whales_357x229.jpg?h=229&w=357&la=en&hash=86A2512B16F18B41E95F360D5A169119",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/killer-whale.mp3?version=1_201811132749", "audio/mp3" }
                },
                scientificName: "Orcinus orca",
                isFavorite: true,
                description: "The killer whale is an apex predator known for its intelligence and teamwork."
            ),
            new AnimalData(
                "Leopard",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/landing-pages/animal-sounds/leopard_357x229.jpg?h=229&w=357&la=en&hash=D9512FDBF1B715F3E765424196CEA961",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/leopard.wav?version=1_201811134824", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/leopard.mp3?version=1_201811134819", "audio/mp3" }
                },
                scientificName: "Panthera pardus",
                isFavorite: false,
                description: "The leopard is a stealthy predator known for its speed and climbing ability."
            ),
            new AnimalData(
                "Lowland Gorilla",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/bgt-animals/2017_buschgardenstampabay_animals_gorillas4_357x229.jpg?h=229&w=357&la=en&hash=32DF6366A292D9A0F9762A7A0876419E",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/gorilla2.wav?version=1_201811134826", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/gorilla.mp3?version=1_201811134818", "audio/mp3" }
                },
                scientificName: "Gorilla gorilla gorilla",
                isFavorite: true,
                description: "The lowland gorilla is a strong and intelligent primate native to African forests."
            ),
            new AnimalData(
                "Penguin",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/birds/penguin-tour-listing.jpg?h=229&w=357&la=en&hash=25A50C5B4DE1D502BB621783B1E5A08D",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/penguin.mp3?version=1_201811133822", "audio/mp3" }
                },
                scientificName: "Spheniscidae",
                isFavorite: false,
                description: "Penguins are flightless birds adapted for life in the water and cold climates."
            ),
            new AnimalData(
                "Pig",
                "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/images/animal-bytes/listing-images/mammals/pot_bellied_pig_357x229.jpg?h=229&w=357&la=en&hash=C95AB99248F12C8BE3655268D9242148",
                new Dictionary<string, string>
                {
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/pig.wav?version=1_201811134818", "audio/wav" },
                    { "https://seaworld.org/-/media/migrated-media/seaworld-dotorg/audio-files/sound-library/pig.mp3?version=1_201811134823", "audio/mp3" }
                },
                scientificName: "Sus scrofa domesticus",
                isFavorite: true,
                description: "The pig is a highly intelligent and social farm animal."
            )

        ];
}
