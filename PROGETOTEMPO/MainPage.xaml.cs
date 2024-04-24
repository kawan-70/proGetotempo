using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Versioning;
using Microsoft.Maui.Controls;

namespace PROGETOTEMPO;

public partial class MainPage : ContentPage
{
	Results resultado;
 
 const string url="HTTPS://Api.HGBrasil.com/weather?woeid=4555927&Key=53a64d66";
	public MainPage()
	{
		InitializeComponent();
		AtualizaTempo();
	}
async void AtualizaTempo()

{

try

  {
  
    var navegador = new HttpClient();
    var response = await navegador.GetAsync(url);
    if (response. IsSuccessStatusCode)
    {
    var content = await response.Content.ReadAsStringAsync();
    resposta = JsonSerializer.Deserialize<Resposta>(content);
    }
    
    PreencherTela();
  }
  catch (Exception e)
  {

}
}


void PreencherTela()
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

