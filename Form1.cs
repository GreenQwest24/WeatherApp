using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using RestSharp;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using RestSharp.Authenticators;


namespace WeattherApp2
{
    public partial class From1 : Form
    {
        private const string API_BASE_URL = "https://api.openweathermap.org/data/2.5/weather";



        public From1()
        {


            InitializeComponent();
            SetClearBackground(); // Set initial clear background
        }



        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string cityName = textBox_CityName.Text;
            FetchWeather(cityName);
        }



        private void FetchWeather(string cityName)
        {
            try
            {
                var client = new RestClient("https://api.openweathermap.org/data/2.5/weather");

                //var request = new RestRequest();
                var request = new RestRequest();
                request.AddParameter("q", cityName);
                request.AddParameter("appid", "494acaff65dcc86fed1a3c6af8b21415"); // Replace with your OpenWeatherMap API key
                request.AddParameter("units", "metric");

                //Store the generated API from the biller portal

                RestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    JObject data = JObject.Parse(response.Content);

                    string weatherDescription = (string)data["weather"][0]["description"];
                    double tempCelsius = (double)data["main"]["temp"];
                    // F=  5/9 × C + 32
                    double tempFahrenheit = .55 * tempCelsius + 32;
                    lblTemp.Text = $"{tempCelsius} °C";
                    //string formatted = $"{number:0.00}";
                    string formatted = $"{tempFahrenheit: 0.00}";
                    MessageBox.Show($"{formatted} °F");
                    label_TempF.Text = $"{formatted} °F";
                    label_WeatherDescription.Text = weatherDescription;
                    UpdateBackground(weatherDescription);
                }
                else
                {
                    MessageBox.Show($"Error fetching weather data: {response.StatusCode}");
                }
            }


            catch (WebException ex)
            {
                MessageBox.Show("Error: Network unreachable or invalid city name");
            }
        }
        private void UpdateBackground(string weatherDescription)
        {
            switch (weatherDescription.ToLower())
            {
                case var desc when desc.Contains("rain"):
                    this.BackColor = Color.LightBlue;
                    break;
                case var desc when desc.Contains("cloud"):
                    this.BackColor = Color.LightGray;
                    break;
                case var desc when desc.Contains("sun"):
                    this.BackColor = Color.LightGoldenrodYellow;
                    break;
                default:
                    this.BackColor = Color.White;
                    break;
            }
        }

        private void SetClearBackground()
        {
            this.BackColor = Color.LightSkyBlue;
        }
    


private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
