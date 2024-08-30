namespace AnimalMatchingGame;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void PlayAgainButton_Clicked(object sender, EventArgs e)
    {
        AnimalButtons.IsVisible = true; // Make the FlexLayout with the emoji buttons visible
        PlayAgainButton.IsVisible = false; // Make the "Play again?" button invisible

        List<string> animalEmoji = [ // Create a list of eight pairs of emoji
            "🐙", "🐙",
            "😺", "😺",
            "🐨", "🐨",
            "🦭", "🦭",
            "🐧", "🐧",
            "🐛", "🐛",
            "🦕", "🦕",
            "🐢", "🐢",
            ];

        foreach (var button in AnimalButtons.Children.OfType<Button>()) // Find every button in the FlexLayout and repeat the statements below for each of them
        {
            int index = Random.Shared.Next(animalEmoji.Count); // Pick a random number between 0 and the number of emoji left in the list and call it "index" 
            string nextEmoji = animalEmoji[index]; // Use the random number called "index" to get a random emoji from the list
            button.Text = nextEmoji; // Make the button display the selected emoji
            animalEmoji.RemoveAt(index); // Remove the chosen emoji from the list
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}