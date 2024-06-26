﻿using System.Reflection.Emit;
using System.Resources;
using System.Runtime.Versioning;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace PROGETOTEMPO;

public partial class MainPage : ContentPage
//_______________________________________________________________________________________________________________
{
	Resposta resposta;
   //info do server
 const string url="https://api.hgbrasil.com/weather?woeid=455927&key=53a64d66";
	public MainPage()
	{
		InitializeComponent();

		

		AtualizaTempo();
	}
//_______________________________________________________________________________________________________________

async void AtualizaTempo()
{

try

  {
			//ele é um transformer ele pega e transforma o Json
  			  var navegador = new HttpClient();
  			  var response = await navegador.GetAsync(url);

             if (response. IsSuccessStatusCode)
    {
   			 var content = await response.Content.ReadAsStringAsync();
   			 resposta = JsonSerializer.Deserialize<Resposta>(content);
    }
    
    PreencherTela();
  }
  //caso ocorra uma exeção ele nao deixar crachar;
  catch (Exception e)
  {
	System.Diagnostics.Debug.WriteLine(e);
  }
}

//_______________________________________________________________________________________________________________

void PreencherTela()
{

				//ele esta pegando o results e tranformando em uma variavel e verificar o que é uma string e o que nao é;
 				labeltemp.Text = resposta.results.temp.ToString();

 	 			labeldescription.Text = resposta.results.description;

 				labelcity.Text = resposta.results.city;

 				labelsunrise.Text = resposta.results.sunrise;

 				labelsunset.Text = resposta.results.sunset;

 				labelmoon_phase.Text = resposta.results.moon_phase;

 				labelcurrently.Text = resposta.results.currently;

 				labelWind_speedy.Text =resposta.results.wind_speedy;

 				labelcloudiness.Text = resposta.results.cloudiness.ToString();

 				labelhumidity.Text = resposta.results.humidity.ToString();
				
				labelrain.Text = resposta.results.rain.ToString();

				//traduçao das fases da lua;
//________________________________________________________________________________________________________________


		       if(resposta.results.moon_phase=="full")
			labelmoon_phase.Text = "Cheia";
		else if(resposta.results.moon_phase=="new")
			labelmoon_phase.Text = "Nova";
		else if(resposta.results.moon_phase=="growing")
			labelmoon_phase.Text = "Crescente";
		else if(resposta.results.moon_phase=="waning")
			labelmoon_phase.Text = "minguante";
		else if(resposta.results.moon_phase=="last_quarter")
			labelmoon_phase.Text = "Ultimo quarto";

//________________________________________________________________________________________________________________

		//troca a img;

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

