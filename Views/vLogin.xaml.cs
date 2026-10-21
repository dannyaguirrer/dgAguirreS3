namespace dgAguirreS3.Views;

public partial class vLogin : ContentPage
{
    // Variables normales (no const), para poder cambiarlas al registrar
    private string usuarioValido = "admin";
    private string contrasenaValida = "1234";

    public vLogin()
    {
        InitializeComponent();
    }

    public vLogin(string usuarioNuevo, string contrasenaNueva)
    {
        InitializeComponent();
        usuarioValido = usuarioNuevo;
        contrasenaValida = contrasenaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        try
        {
            string usuarioIngresado = txtUsuario.Text?.Trim() ?? string.Empty;
            string contrasenaIngresada = txtContraseña.Text ?? string.Empty;

            if (string.IsNullOrWhiteSpace(usuarioIngresado) || string.IsNullOrWhiteSpace(contrasenaIngresada))
            {
                await DisplayAlertAsync("Aviso", "Ingresa el usuario y la contraseña.", "Cerrar");
                return;
            }

            if (string.Equals(usuarioIngresado, usuarioValido, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(contrasenaIngresada, contrasenaValida, StringComparison.Ordinal))
            {
                await Navigation.PushAsync(new vPrincipal(usuarioIngresado));
            }
            else
            {
                await DisplayAlertAsync("Error", "Usuario o contraseña incorrectos.", "Cerrar");
            }
        }
        catch (Exception ex)
        {
            // Para revisar errores mientras pruebo
            await DisplayAlertAsync("Error", ex.Message, "Cerrar");
        }
    }

    private async void btnRegistrarse_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.vRegistro());
    }
}