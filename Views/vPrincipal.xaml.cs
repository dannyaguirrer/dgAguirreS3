namespace dgAguirreS3.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal( string usuario)
	{
		InitializeComponent();
		DisplayAlertAsync("Bienvenido", usuario,"cerrar");
		lblUsuario.Text = "Usuario Conectado: " + usuario;
	}

   

    private async void btnInicio_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}