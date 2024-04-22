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

 				labeldescripition.Text = resultado.description.ToString();

 				labelcity.Text = resultado.city;

 				labelsunrise.Text = resultado.sunrise;

 				labelsunset.Text = resultado.sunset;

 				labeltimizone.Text = resultado.timezone;

 				labelmoon_phase.Text = resultado.moon_phase;

 				labelcurrently.Text = resultado.currently;

 				labelwind_speedy.Text = resultado.Wind_speedy;

 				labelclaudiness.Text = resultado.claudiness;

 				labelcodition_code.Text = resultado.codition_code;

 				labelImg_id.Text = resultado.Img_id;

 				labelhumidity.Text = resultado.humidity.ToString();


}
}

