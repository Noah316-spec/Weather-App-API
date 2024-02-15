using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System.CodeDom.Compiler;

namespace WetterApp_mit_API
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public string ApiKey = "9809e953ca751c5321e473c36fbcd0de";

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 80; // Setzt das Intervall auf 100 Millisekunden
            timer.Tick += (s, args) =>
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); // Entfernt das letzte Zeichen
                }
                else
                {
                    timer.Stop(); // Stoppt den Timer, wenn der gesamte Text entfernt wurde
                }
            };
            timer.Start(); // Startet den Timer
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {

                string link = "https://api.openweathermap.org/data/2.5/weather?q=" + textBox1.Text + "&units=metric&appid=" + ApiKey;
                var json = web.DownloadString(link); // download data in json 
                Weatherinfo.root Info = JsonConvert.DeserializeObject<Weatherinfo.root>(json); //daten umwandeln damit wir sie lesen können
                picicon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                lblCond.Text = Info.weather[0].main;
                lbldetails.Text = Info.weather[0].description;
                lbltemp.Text =  Convert.ToString(Info.main.temp) + " °C";
                lbltempmin.Text = Convert.ToString(Info.main.temp_min) + " °C";
                lbltempmax.Text = Convert.ToString(Info.main.temp_max) + " °C";
                lblhumid.Text = Convert.ToString(Info.main.humidity) +  " %";
                lblpre.Text = Convert.ToString(Info.main.pressure) + " N/m²";
                lblspeed.Text = Convert.ToString(Info.wind.speed)+ " m/s";

            }

        }

    }
}
