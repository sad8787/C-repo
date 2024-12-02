using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using api_openweathermap_org.NewFolder;

namespace api_openweathermap_org
{
    public partial class Form1 : Form
    {
        string apiKey = "4e837661f5da0d80953dd905b5f6e073";
        public Form1()
        {
            InitializeComponent();
            if (textBoxCity.Text == "")
                textBoxCity.Text = "moscow";
            getWeatherData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxCity.Text == "")
                textBoxCity.Text = "moscow";
            getWeatherData();

        }

        void getWeatherData()
        {
            int lon = 0;
            int lat = 0;
            using (WebClient web = new WebClient()) {
                string url1 =string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", textBoxCity.Text, apiKey) ;
                try
                {
                    var json = web.DownloadString(url1);       
                    WeatherData.root wether = JsonConvert.DeserializeObject<WeatherData.root>(json);
                    lon = (int)wether.coord.lon;
                    lat= (int)wether.coord.lat;                     
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Error", e.Message);
                }             
                
            }
            using (WebClient web = new WebClient()) {
                try
                {

                    string url2 = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=part&appid={2}&units=metric", lat, lon, apiKey);
                    var json2 = web.DownloadString(url2);
                    Forecast.root forecast = JsonConvert.DeserializeObject<Forecast.root>(json2);
                    //Now
                    pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + forecast.current.weather[0].icon + ".png";
                    labelDate1.Text = combertToDateTimeIsUTC_Desviation(forecast.timezone_offset).ToString("hh : mm");
                    labelCondition1.Text = forecast.current.weather[0].main;
                    labeldescription1.Text = forecast.current.weather[0].description;                    
                    labelTemp1.Text = string.Format("{0:N2}", forecast.current.temp) + " °C";//ver formato
                    LabelperceivedTemp1.Text = string.Format("{0:N2}", forecast.current.feels_like) + " °C";
                    labelDiffereceTemp1.Text =  "0 °C";
                    labelTempMin1.Text = " -"; //ver formato Celcius
                    labelTempMax1.Text = " -";//ver formato Celcius
                    labelwindspeed1.Text = forecast.current.wind_speed + " m/s";//ver formato                    
                    labelHoursSun1.Text = (((forecast.current.sunset - forecast.current.sunrise) / 60) / 60).ToString() + " : " + (((forecast.current.sunset - forecast.current.sunrise) / 60) % 60).ToString();
                    //Forecast 2
                    int d = 0;
                    pictureBox2.ImageLocation = "https://openweathermap.org/img/w/" + forecast.daily[d].weather[0].icon + ".png";
                    labelDate2.Text = combertToDateTime(forecast.daily[d].dt).ToString("MMM dd");
                    labelCondition2.Text = forecast.daily[d].weather[0].main;
                    labeldescription2.Text = forecast.daily[d].weather[0].description;
                    labelTemp2.Text = string.Format("{0:N2}", forecast.daily[d].temp.day) + " °C";//ver formato
                    LabelperceivedTemp2.Text = string.Format("{0:N2}", forecast.daily[d].feels_Like.day) + " °C";
                    labelDiffereceTemp2.Text = string.Format("{0:N2}", forecast.daily[d].Temperature_difference_at_night()) + " °C";//calcular correctamente
                    labelTempMin2.Text = string.Format("{0:N2}", forecast.daily[d].temp.min) + " °C"; //ver formato Celcius
                    labelTempMax2.Text = string.Format("{0:N2}", forecast.daily[d].temp.max) + " °C";//ver formato Celcius
                    labelwindspeed2.Text = forecast.daily[d].wind_speed + " m/s";//ver formato                    
                    labelHoursSun2.Text = ((forecast.daily[d].Daylight_hours() / 60) / 60).ToString() + " : " + ((forecast.daily[d].Daylight_hours() / 60) % 60).ToString();
                    //Forecast 3
                    d = 1;
                    pictureBox3.ImageLocation = "https://openweathermap.org/img/w/" + forecast.daily[d].weather[0].icon + ".png";
                    labelDate3.Text = combertToDateTime(forecast.daily[d].dt).ToString("MMM dd");
                    labelCondition3.Text = forecast.daily[d].weather[0].main;
                    labeldescription3.Text = forecast.daily[d].weather[0].description;
                    labelTemp3.Text = string.Format("{0:N2}", forecast.daily[d].temp.day) + " °C";//ver formato
                    LabelperceivedTemp3.Text = string.Format("{0:N2}", forecast.daily[d].feels_Like.day) + " °C";
                    labelDiffereceTemp3.Text = string.Format("{0:N2}", forecast.daily[d].Temperature_difference_at_night()) + " °C";//calcular correctamente
                    labelTempMin3.Text = string.Format("{0:N2}", forecast.daily[d].temp.min) + " °C"; //ver formato Celcius
                    labelTempMax3.Text = string.Format("{0:N2}", forecast.daily[d].temp.max) + " °C";//ver formato Celcius
                    labelwindspeed3.Text = forecast.daily[d].wind_speed + " m/s";//ver formato                    
                    labelHoursSun3.Text = ((forecast.daily[d].Daylight_hours() / 60) / 60).ToString() + " : " + ((forecast.daily[d].Daylight_hours() / 60) % 60).ToString();

                    //Forecast 4
                    d = 2;
                    pictureBox4.ImageLocation = "https://openweathermap.org/img/w/" + forecast.daily[d].weather[0].icon + ".png";
                    labelDate4.Text = combertToDateTime(forecast.daily[d].dt).ToString("MMM dd");
                    labelCondition4.Text = forecast.daily[d].weather[0].main;
                    labeldescription4.Text = forecast.daily[d].weather[0].description;
                    labelTemp4.Text = string.Format("{0:N2}", forecast.daily[d].temp.day) + " °C";//ver formato
                    LabelperceivedTemp4.Text = string.Format("{0:N2}", forecast.daily[d].feels_Like.day) + " °C";
                    labelDiffereceTemp4.Text = string.Format("{0:N2}", forecast.daily[d].Temperature_difference_at_night()) + " °C";//calcular correctamente
                    labelTempMin4.Text = string.Format("{0:N2}", forecast.daily[d].temp.min) + " °C"; //ver formato Celcius
                    labelTempMax4.Text = string.Format("{0:N2}", forecast.daily[d].temp.max) + " °C";//ver formato Celcius
                    labelwindspeed4.Text = forecast.daily[d].wind_speed + " m/s";//ver formato                    
                    labelHoursSun4.Text = ((forecast.daily[d].Daylight_hours() / 60) / 60).ToString() + " : " + ((forecast.daily[d].Daylight_hours() / 60) % 60).ToString();

                    //Forecast 5
                    d = 3;
                    pictureBox5.ImageLocation = "https://openweathermap.org/img/w/" + forecast.daily[d].weather[0].icon + ".png";
                    labelDate5.Text = combertToDateTime(forecast.daily[d].dt).ToString("MMM dd");
                    labelCondition5.Text = forecast.daily[d].weather[0].main;
                    labeldescription5.Text = forecast.daily[d].weather[0].description;
                    labelTemp5.Text = string.Format("{0:N2}", forecast.daily[d].temp.day) + " °C";//ver formato
                    LabelperceivedTemp5.Text = string.Format("{0:N2}", forecast.daily[d].feels_Like.day) + " °C";
                    labelDiffereceTemp5.Text = string.Format("{0:N2}", forecast.daily[d].Temperature_difference_at_night()) + " °C";//calcular correctamente
                    labelTempMin5.Text = string.Format("{0:N2}", forecast.daily[d].temp.min) + " °C"; //ver formato Celcius
                    labelTempMax5.Text = string.Format("{0:N2}", forecast.daily[d].temp.max) + " °C";//ver formato Celcius
                    labelwindspeed5.Text = forecast.daily[d].wind_speed + " m/s";//ver formato                    
                    labelHoursSun5.Text = ((forecast.daily[d].Daylight_hours() / 60) / 60).ToString() + " : " + ((forecast.daily[d].Daylight_hours() / 60) % 60).ToString();
                    //Forecast 5
                    d = 4;
                    pictureBox6.ImageLocation = "https://openweathermap.org/img/w/" + forecast.daily[d].weather[0].icon + ".png";
                    labelDate6.Text = combertToDateTime(forecast.daily[d].dt).ToString("MMM dd");
                    labelCondition6.Text = forecast.daily[d].weather[0].main;
                    labeldescription6.Text = forecast.daily[d].weather[0].description;
                    labelTemp6.Text = string.Format("{0:N2}", forecast.daily[d].temp.day) + " °C";//ver formato
                    LabelperceivedTemp6.Text = string.Format("{0:N2}", forecast.daily[d].feels_Like.day) + " °C";
                    labelDiffereceTemp6.Text = string.Format("{0:N2}", forecast.daily[d].Temperature_difference_at_night()) + " °C";//calcular correctamente
                    labelTempMin6.Text = string.Format("{0:N2}", forecast.daily[d].temp.min) + " °C"; //ver formato Celcius
                    labelTempMax6.Text = string.Format("{0:N2}", forecast.daily[d].temp.max) + " °C";//ver formato Celcius
                    labelwindspeed6.Text = forecast.daily[d].wind_speed + " m/s";//ver formato                    
                    labelHoursSun6.Text = ((forecast.daily[d].Daylight_hours() / 60) / 60).ToString() + " : " + ((forecast.daily[d].Daylight_hours() / 60) % 60).ToString();


                    double differenceTemp = 0;
                    long dtTemp = 0;
                    long daylight_hours = 0;
                    long dtDaylight = 0;
                    forecast.Temperature_difference_at_night(out differenceTemp, out dtTemp);
                    forecast.Day_with_mor_light(out daylight_hours,out dtDaylight);
                    labelA.Text = "The day with the smallest temperature difference " + combertToDateTime(dtTemp).ToString("MMM d") + "  with " + string.Format("{0:N2}", differenceTemp)  + " °C";
                    labelB.Text = "The day with more hours of light " + combertToDateTime(dtDaylight).ToString("MMM d")+ "  with " + ((daylight_hours / 60) / 60).ToString()+":"+ ((daylight_hours / 60)% 60).ToString()+" hours";
                }
                catch (Exception e)
                {

                    Console.WriteLine("{0} Error", e.Message);
                }
            }
        }
        DateTime combertToDateTimeIsUTC_Desviation(long second) 
        {
            long unixTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            unixTime = unixTime + second;
            return combertToDateTime(unixTime);
        }
        DateTime combertToDateTime(long second)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddHours(-3);
            day =day.AddSeconds(second).ToLocalTime();
            return day;
        }
        DateTime combertToDateTime2(long second)
        {
            DateTime day = new DateTime(1900, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddHours(-3);
            day = day.AddSeconds(second).ToLocalTime();
            return day;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
