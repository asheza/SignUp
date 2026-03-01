using SignUp.Pages;

namespace SignUp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
              
        Routing.RegisterRoute("profile", typeof(ProfilePage));
    }
}
