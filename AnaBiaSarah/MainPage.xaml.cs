namespace AnaBiaSarah;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}
 private void BotaoIniciarFoiClicado(object sender, EventArgs args)
  {
  //  if (Application.Current != null)
  //    Application.Current.MainPage = new GamePage();
  }

 private void BotaoSobreFoiClicado(object sender, EventArgs args)
  {
    frameAbout.IsVisible = true;
  }


private void BotaoVoltarFoiClicado(object sender, EventArgs args)
  {
    frameAbout.IsVisible = true;
  }
 

}