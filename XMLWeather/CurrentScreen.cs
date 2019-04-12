using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            currentLabel.Text = DateTime.Now.ToString("dddd");
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.°C");
            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.°C");
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.°C");
            timeLabel.Text = DateTime.Now.ToString("hh:mm tt");
            if (Convert.ToDouble(Form1.days[0].condition) >= 200 && Convert.ToDouble(Form1.days[0].condition) <= 232)
            {
                Form1.days[0].condition = "Thunderstorm";
                iconLabel.Image = Properties.Resources._11d;
            }
            else if (Convert.ToDouble(Form1.days[0].condition) >= 300 && Convert.ToDouble(Form1.days[0].condition) <= 321)
            {
                Form1.days[0].condition = "Drizzle";
                iconLabel.Image = Properties.Resources._10d;
            }
            else if (Convert.ToDouble(Form1.days[0].condition) >= 500 && Convert.ToDouble(Form1.days[0].condition) <= 531)
            {
                Form1.days[0].condition = "Rain";
                iconLabel.Image = Properties.Resources._09d;
            }
            else if (Convert.ToDouble(Form1.days[0].condition) >= 600 && Convert.ToDouble(Form1.days[0].condition) <= 622)
            {
                Form1.days[0].condition = "Snow";
                iconLabel.Image = Properties.Resources._13d;
            }
            else if (Convert.ToDouble(Form1.days[0].condition) == 800)
            {
                Form1.days[0].condition = "Clear";
                iconLabel.Image = Properties.Resources._01d;
            }
            else if (Convert.ToDouble(Form1.days[0].condition) >= 800 && Convert.ToDouble(Form1.days[0].condition) <= 804)
            {
                Form1.days[0].condition = "Clouds";
                iconLabel.Image = Properties.Resources._03d;
            }
            conditionLabel.Text = Form1.days[0].condition;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
