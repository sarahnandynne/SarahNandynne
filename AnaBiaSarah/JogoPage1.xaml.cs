namespace AnaBiaSarah;

public partial class JogoPage1 : ContentPage
{


	public JogoPage1()
	{
		InitializeComponent();
    }
    private void BotaoSimFoiClicado(object sender, EventArgs args)
  {
  if (Application.Current != null)
    Application.Current.MainPage = new RespostaPage1();
  }
  private void BotaoNaoFoiClicado(object sender, EventArgs args)
  {
  if (Application.Current != null)
    Application.Current.MainPage = new JogoPage2();
  }
}