namespace AnaBiaSarah;

public partial class JogoPage2 : ContentPage
{


	public JogoPage2()
	{
		InitializeComponent();
    }
    private void BotaoVoltarAoInicioFoiClicado(object sender, EventArgs args)
  {
  if (Application.Current != null)
    Application.Current.MainPage = new JogoPage();
  }
}