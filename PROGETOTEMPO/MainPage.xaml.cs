using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Versioning;
using Microsoft.Maui.Controls;

namespace PROGETOTEMPO;

public partial class MainPage : ContentPage
{
	Results resultado;

	public MainPage()
	{
		InitializeComponent();
		TestaLayout();
		PreencherPagina();
	}

	void TestaLayout()
	{
		resultado = new Results();
		resultado.temp = 23;
		resultado.description = "Tempo nublado";


	}

	void PreencherPagina()
	{
		labelTemp.Text = resultado.temp.ToString();
		
	}
}

