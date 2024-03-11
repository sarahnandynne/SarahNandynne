namespace AnaBiaSarah;

public partial class JogoPage : ContentPage
{


	public JogoPage()
	{
		InitializeComponent();
    }
	void Botao1FoiClicado (object sender,EventArgs args)
	{
      Application.Current.MainPage = new JogoPage1();
	}

	void Botao2FoiClicado (object sender,EventArgs args)
	{
     Application.Current.MainPage = new JogoPage2();
	}

	private void BotaoVoltar2FoiClicado(object sender, EventArgs args)
  {
    Application.Current.MainPage = new MainPage();
  }
    
  }