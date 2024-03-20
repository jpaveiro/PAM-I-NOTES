namespace Notes;

public partial class NotePage : ContentPage
{
    string path = Path.Combine(FileSystem.AppDataDirectory, "data.txt");
    string text = "";

	public NotePage()
	{
		InitializeComponent();
        if (File.Exists(path))
        {
            FileEditor.Text = File.ReadAllText(path);
        }
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        text = FileEditor.Text;
        File.WriteAllText(path, text);
        DisplayAlert("Sucesso", $"Arquivo salvo com sucesso no local: {path}" , "Ok");
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            FileEditor.Text = "";
            File.Delete(path);
        }
    }
}
