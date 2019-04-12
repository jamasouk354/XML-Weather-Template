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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            for (int i = 1; i < Form1.days.Count; i++)
            {
                if (Convert.ToDouble(Form1.days[i].condition) >= 200 && Convert.ToDouble(Form1.days[i].condition) <= 232)
                {
                    Form1.days[i].condition = "Thunderstorm";
                    day1.Image = Properties.Resources._11d;
                    day2.Image = Properties.Resources._11d;
                    day3.Image = Properties.Resources._11d;
                }
                else if (Convert.ToDouble(Form1.days[i].condition) >= 300 && Convert.ToDouble(Form1.days[i].condition) <= 321)
                {
                    Form1.days[i].condition = "Drizzle";
                    day1.Image = Properties.Resources._10d;
                    day2.Image = Properties.Resources._10d;
                    day3.Image = Properties.Resources._10d;
                }
                else if (Convert.ToDouble(Form1.days[i].condition) >= 500 && Convert.ToDouble(Form1.days[i].condition) <= 531)
                {
                    Form1.days[i].condition = "Rain";
                    day1.Image = Properties.Resources._09d;
                    day2.Image = Properties.Resources._09d;
                    day3.Image = Properties.Resources._09d;
                }
                else if (Convert.ToDouble(Form1.days[i].condition) >= 600 && Convert.ToDouble(Form1.days[i].condition) <= 622)
                {
                    Form1.days[i].condition = "Snow";
                    day1.Image = Properties.Resources._13d;
                    day2.Image = Properties.Resources._13d;
                    day3.Image = Properties.Resources._13d;
                }
                else if (Convert.ToDouble(Form1.days[i].condition) == 800)
                {
                    Form1.days[i].condition = "Clear";
                    day1.Image = Properties.Resources._01d;
                    day2.Image = Properties.Resources._01d;
                    day3.Image = Properties.Resources._01d;
                }
                else if (Convert.ToDouble(Form1.days[i].condition) >= 800 && Convert.ToDouble(Form1.days[i].condition) <= 804)
                {
                    Form1.days[i].condition = "Clouds";
                    day1.Image = Properties.Resources._03d;
                    day2.Image = Properties.Resources._03d;
                    day3.Image = Properties.Resources._03d;
                }
            }
            
            currentLabel.Text = DateTime.Now.ToString("dddd");

            
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.°C");
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.°C");
            con1.Text = Form1.days[1].condition;
            date1.Text = DateTime.Now.AddDays(2).ToString();
            date1.Text = Form1.days[1].date;
            date1.Text = DateTime.Now.ToString("dddd");

            
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.°C");
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.°C");
            con2.Text = Form1.days[2].condition;
            date2.Text = Form1.days[2].date;
            date2.Text = DateTime.Now.AddDays(1).ToString();


            
            min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.°C");
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.°C");
            con3.Text = Form1.days[3].condition;
            date3.Text = Form1.days[3].date;
            date3.Text = DateTime.Now.AddDays(1).ToString();

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
