namespace SignUp.Pages;

public partial class SignupPage : ContentPage
{
    public SignupPage()
    {
        InitializeComponent();
    }

    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        ErrorLabel.IsVisible = false;
        ErrorLabel.Text = string.Empty;

        string username = UsernameEntry.Text?.Trim() ?? string.Empty;
        string email = EmailEntry.Text?.Trim() ?? string.Empty;
        string password = PasswordEntry.Text ?? string.Empty;
        string confirmPassword = ConfirmPasswordEntry.Text ?? string.Empty;

        
        if (string.IsNullOrWhiteSpace(username) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(confirmPassword))
        {
            ShowError("Please fill out all fields.");
            return;
        }

        
        if (!string.Equals(password, confirmPassword))
        {
            ShowError("Passwords do not match.");
            return;
        }

        
        if (!email.Contains("@") || !email.Contains("."))
        {
            ShowError("Please enter a valid email.");
            return;
        }

        
        string u = Uri.EscapeDataString(username);
        string eMail = Uri.EscapeDataString(email);

        
        await Shell.Current.GoToAsync($"profile?username={u}&email={eMail}");
             
    }

    private void ShowError(string message)
    {
        ErrorLabel.Text = message;
        ErrorLabel.IsVisible = true;
    }
}