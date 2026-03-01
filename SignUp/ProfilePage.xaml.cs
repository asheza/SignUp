using System.ComponentModel;

namespace SignUp.Pages;


[QueryProperty(nameof(Username), "username")]
[QueryProperty(nameof(Email), "email")]
public partial class ProfilePage : ContentPage
{
    private string _username = string.Empty;
    private string _email = string.Empty;

    public string Username
    {
        get => _username;
        set
        {
            _username = Uri.UnescapeDataString(value ?? string.Empty);
            if (UsernameLabel != null)
                UsernameLabel.Text = _username;
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            _email = Uri.UnescapeDataString(value ?? string.Empty);
            if (EmailLabel != null)
                EmailLabel.Text = _email;
        }
    }

    public ProfilePage()
    {
        InitializeComponent();
    }

    private async void OnSignOutClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//signup");
    }
}