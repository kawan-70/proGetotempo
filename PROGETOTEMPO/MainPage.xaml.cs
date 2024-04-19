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

	 				labeldescripition.Text = resultado.description();

	 				labelcity.Text = resultado.city.ToString();

	 				labelsunrise.Text = resultado.sunrise.ToString();

	 				label.sunsetText = resultado.sunset.ToString();

	 				labeltimizone.Text = resultado.timezone.ToString();

	 				labelmoon_phase.Text = resultado.moon_phase.ToString();

	 				labelcurrently.Text = resultado.currently.ToString();

	 				labelwind_speedy.Text = resultado.Wind_speedy.ToString();

	 				labelclaudiness.Text = resultado.claudiness.ToString();

	 				labelcodition_code.Text = resultado.codition_code.ToString();

	 				labelImg_id.Text = resultado.Img_id.ToString();

	 				labelphumidity.Text = resultado.humidity.ToString();


	}
}

