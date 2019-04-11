﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            currentLabel.Text = DateTime.Now.ToString("dddd");

            date1.Text = Form1.days[1].date;
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.°C");
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.°C");
            con1.Text = Form1.days[1].condition;

            date2.Text = Form1.days[2].date;
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.°C");
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.°C");
            con2.Text = Form1.days[2].condition;

            date3.Text = Form1.days[3].date;
            min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.°C");
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.°C");
            con3.Text = Form1.days[3].condition;

            timeLabel.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
