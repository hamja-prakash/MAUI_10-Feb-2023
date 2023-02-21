namespace MAUISampleDemo.View;

public partial class FilePickerPage : ContentPage
{
	public FilePickerPage()
	{
		InitializeComponent();
	}

    private async void PickImage_Clicked(object sender, EventArgs e)
    {
        var result = await FilePicker.PickAsync(new PickOptions
        {
            PickerTitle = "Pick Image Please",
            FileTypes = FilePickerFileType.Images
        });

        if (result == null)
            return;

        var stream = await result.OpenReadAsync();

        myImage.Source = ImageSource.FromStream(() => stream);
    }

    private async void PickImages_Clicked(object sender, EventArgs e)
    {
        var results = await FilePicker.PickMultipleAsync(new PickOptions
        {
        });

        foreach (var result in results)
        {
            await DisplayAlert("You picked...", result.FileName, "OK");
        }
    }
}