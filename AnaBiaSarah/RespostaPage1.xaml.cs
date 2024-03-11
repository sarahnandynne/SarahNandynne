namespace AnaBiaSarah;

public partial class RespostaPage1 : ContentPage
{


	public RespostaPage1()
	{
		InitializeComponent();
    }
private void BotaoInicioFoiClicado(object sender, EventArgs args)
  {
  if (Application.Current != null)
    Application.Current.MainPage = new MainPage();
  }
}