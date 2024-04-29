using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Versioning;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace PROGETOTEMPO;

public partial class MainPage : ContentPage
{
	Resposta resposta;
 
 const string url="https://api.hgbrasil.com/weather?woeid=455927&key=53a64d66";
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
	System.Diagnostics.Debug.WriteLine(e);
  }
}


void PreencherTela()
{
 				labeltemp.Text = resposta.results.temp.ToString();

 	 			labeldescription.Text = resposta.results.description;

 				labelcity.Text = resposta.results.city;

 				labelsunrise.Text = resposta.results.sunrise;

 				labelsunset.Text = resposta.results.sunset;

 				labelmoon_phase.Text = resposta.results.moon_phase;

 				labelcurrently.Text = resposta.results.currently;

 				labelWind_speedy.Text =resposta.results.wind_speedy;

 				labelcloudiness.Text = resposta.results.cloudiness.ToString();

 				//labelcodition_code.Text = resposta.results.codition_code;

 				//labelImg_id.Text = resposta.results.Img_id;

 				labelhumidity.Text = resposta.results.humidity.ToString();
				
				labelrain.Text = resposta.results.rain.ToString();


		       if(resposta.results.moon_phase=="full")
			labelmoon_phase.Text = "Cheia";
		else if(resposta.results.moon_phase=="new")
			labelmoon_phase.Text = "Nova";
		else if(resposta.results.moon_phase=="growing")
			labelmoon_phase.Text = "Crescente";
		else if(resposta.results.moon_phase=="waning")
			labelmoon_phase.Text = "minguante";


		if(resposta.results.currently=="dia")
		{
			if(resposta.results.rain>=10)
			labelImg_id.Source="diachuvoso.png";
			else if(resposta.results.cloudiness>=10)
			labelImg_id.Source="dianublado.png";
			else
			labelImg_id.Source="diaensolarado.png";
		}
		else
		{
			if(resposta.results.rain>=10)
			 labelImg_id.Source="noitechuvuso.png";
			 else if (resposta.results.cloudiness>=10)
			 labelImg_id.Source="noitenublado.png";
			 else
			 labelImg_id.Source="noite.png";
		}



}
}

