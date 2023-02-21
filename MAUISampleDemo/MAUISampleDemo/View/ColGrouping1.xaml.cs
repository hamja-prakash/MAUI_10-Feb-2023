using MAUISampleDemo.Model;

namespace MAUISampleDemo.View;

public partial class ColGrouping1 : ContentPage
{
    public List<AnimalGroup> Animals { get; set; } = new List<AnimalGroup>();
    public ColGrouping1()
	{
		InitializeComponent();
        BindAnimalData();

    }

	public void BindAnimalData()
	{
        try
        {
            Animals.Add(new AnimalGroup("Bears", new List<Animal>
        {
            new Animal
            {
                Name = "American Black Bear",
                Location = "North America",
                Details = "Details about the bear go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/08/01_Schwarzb�r.jpg"
            },
            new Animal
            {
                Name = "Asian Black Bear",
                Location = "Asia",
                Details = "Details about the bear go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG/180px-Ursus_thibetanus_3_%28Wroclaw_zoo%29.JPG"
            },
        }));

            Animals.Add(new AnimalGroup("Monkeys", new List<Animal>
        {
            new Animal
            {
                Name = "Baboon",
                Location = "Africa & Asia",
                Details = "Details about the monkey go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            },
            new Animal
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                Details = "Details about the monkey go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            },
            new Animal
            {
                Name = "Blue Monkey",
                Location = "Central and East Africa",
                Details = "Details about the monkey go here.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            },
        }));
            clvAnimals.ItemsSource = Animals.ToList();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}