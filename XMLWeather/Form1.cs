﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                Day d = new Day();
                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");
                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");
                reader.ReadToFollowing("symbol");
                d.condition = reader.GetAttribute("number");
                //TODO: if day object not null add to the days list
                //if (Convert.ToInt16(d.condition) >= 200 && Convert.ToInt16(d.condition) <= 232) { d.condition = "Thunderstorm"; }
                //if (Convert.ToInt16(d.condition) >= 300 && Convert.ToInt16(d.condition) <= 321) { d.condition = "Drizzle"; }
                //if (Convert.ToInt16(d.condition) >= 500 && Convert.ToInt16(d.condition) <= 531) { d.condition = "Rain"; }
                //if (Convert.ToInt16(d.condition) >= 600 && Convert.ToInt16(d.condition) <= 622) { d.condition = "Snow"; }
                //if (Convert.ToInt16(d.condition) >= 701 && Convert.ToInt16(d.condition) <= 781) { d.condition = "Atmosphere"; }
                //if (Convert.ToInt16(d.condition) == 800) { d.condition = "Clear"; }
                //if (Convert.ToInt16(d.condition) >= 801 && Convert.ToInt16(d.condition) <= 804) { d.condition = "Clouds"; }
                if (d.date != null)
                {
                    days.Add(d);
                }
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            reader.ReadToFollowing("weather");
            days[0].location = reader.GetAttribute("value");
        }
    }
}
