using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Versioning;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace PROGETOTEMPO;

public partial class MainPage : ContentPage
{
	Resposta resposta;
 
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
 				labeltemp.Text = resposta.results.temp.ToString();

 	 			labeldescripition.Text = resposta.results.description.ToString();

 				labelcity.Text = resposta.results.city;

 				labelsunrise.Text = resposta.results.sunrise;

 				labelsunset.Text = resposta.results.sunset;

 				labeltimizone.Text = resposta.results.timezone;

 				labelmoon_phase.Text = resposta.results.moon_phase;

 				labelcurrently.Text = resposta.results.currently;

 				labelWind_speedy.Text =resposta.results.Wind_speedy;

 				labelclaudiness.Text = resposta.results.claudiness;

 				labelcodition_code.Text = resposta.results.codition_code;

 				labelImg_id.Text = resposta.results.Img_id;

 				labelhumidity.Text = resposta.results.humidity.ToString();


		



}
}

