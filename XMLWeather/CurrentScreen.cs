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
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.°C");
            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.°C");
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.°C");
            conditionLabel.Text = Form1.days[0].condition;
            timeLabel.Text = DateTime.Now.ToString("hh:mm:ss");
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
