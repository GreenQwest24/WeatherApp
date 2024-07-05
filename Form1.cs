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
using System.Speech.Recognition;
using System.Speech.Synthesis;


namespace WeattherApp2
{
    public partial class From1 : Form
    {
        private const string API_BASE_URL = "https://api.openweathermap.org/data/2.5/weather";
        private SpeechRecognitionEngine recognizer;
        private SpeechSynthesizer synthesizer;





        public From1()
        {


            InitializeComponent();
            SetClearBackground(); // Set initial clear background

            // Initialize speech recognition and synthesis
            recognizer = new SpeechRecognitionEngine();
            synthesizer = new SpeechSynthesizer();

            // Configure speech recognition
            ConfigureSpeechRecognition();

            // Handle recognized speech
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
        }

        private void ConfigureSpeechRecognition()
        {
            // Create a grammar for recognizing weather commands
            Choices commands = new Choices(new string[] { "weather in", "temperature in", "forecast for" });
            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(commands);
            Grammar grammar = new Grammar(grammarBuilder);

            // Load the grammar into the recognizer
            recognizer.LoadGrammar(grammar);

            // Set input to the default audio device
            recognizer.SetInputToDefaultAudioDevice();
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Handle recognized speech here
            string command = e.Result.Text;
            Console.WriteLine("Recognized command: " + command);

            // Extract the city name from the recognized command
            string cityName = command.Replace("weather in", "").Trim();

            // Fetch weather based on the recognized city name
            FetchWeather(cityName);
        }



        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string cityName = textBox_CityName.Text;
            FetchWeather(cityName);
            FetchSunriseTime(cityName);
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
                    // F=  9/5 × C + 32
                    double tempFahrenheit = 1.8 * tempCelsius + 32;
                    lblTemp.Text = $"{tempCelsius} °C";
                    //string formatted = $"{number:0.00}";
                    string formatted = $"{tempFahrenheit: 0.00}";
                    //MessageBox.Show($"{formatted} °F");
                    label_TempF.Text = $"{formatted} °F";
                    label_WeatherDescription.Text = weatherDescription;
                    UpdateBackground(weatherDescription);

                    // Speak the weather information
                    Speak($"Current weather in {cityName}:{tempFahrenheit} degrees Fahrenheit, {tempCelsius} degrees Celsius, {weatherDescription}");
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


        private void FetchSunriseTime(string cityName)
        {
            try
            {
                var client = new RestClient("https://api.openweathermap.org/data/2.5/weather");

                var request = new RestRequest();
                request.AddParameter("q", cityName);
                request.AddParameter("appid", "494acaff65dcc86fed1a3c6af8b21415"); // Replace with your OpenWeatherMap API key

                RestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    JObject data = JObject.Parse(response.Content);

                    // Extract sunrise time (in UTC seconds since Unix epoch)
                    long sunriseUnix = (long)data["sys"]["sunrise"];

                    // Convert Unix timestamp to DateTime

                    // Convert Unix timestamp to DateTime
                    DateTime sunriseDateTime = DateTimeOffset.FromUnixTimeSeconds(sunriseUnix).DateTime;





                    MessageBox.Show($"Sunrise time in {cityName}: {sunriseDateTime.ToShortTimeString()}");

                    // Optionally, update your UI to display the sunrise time
                    label_Sunrise.Text = $"Sunrise: {sunriseDateTime.ToShortTimeString()}";
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


         private void Speak(string text)
        {
            // Speak the provided text
            synthesizer.SpeakAsync(text);
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
            // Start listening for voice commands when the form loads
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
            Console.WriteLine("Listening for commands...");

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            recognizer.Dispose();
            synthesizer.Dispose();
        }


    }
}
