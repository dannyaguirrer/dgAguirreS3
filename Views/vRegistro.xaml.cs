namespace dgAguirreS3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private async void btnAgregarUsuario_Clicked(object sender, EventArgs e)
    {
        string UsuarioNuevo = txtUsuarioNuevo.Text;
        string ContrasenaNueva = txtNuevaContrasena.Text;

        await Navigation.PushAsync(new vLogin(UsuarioNuevo, ContrasenaNueva));
        await DisplayAlertAsync("operacion exitosa", "Usuario Nuevo Creado", "Cerrar");
    }
    private async void btnVolver_Clicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
  
}