﻿namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 45);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(102, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(102, 45);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "3 Days";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(250, 10);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(54, 26);
            this.timeLabel.TabIndex = 78;
            this.timeLabel.Text = "time";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.conditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionLabel.ForeColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(20, 262);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(110, 26);
            this.conditionLabel.TabIndex = 92;
            this.conditionLabel.Text = "conditions";
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(25, 50);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(208, 55);
            this.cityOutput.TabIndex = 90;
            this.cityOutput.Text = "Stratford";
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(224, 309);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(63, 31);
            this.minOutput.TabIndex = 89;
            this.minOutput.Text = "       ";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(161, 309);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(57, 31);
            this.minLabel.TabIndex = 88;
            this.minLabel.Text = "Min\r\n";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(224, 257);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(70, 31);
            this.maxOutput.TabIndex = 87;
            this.maxOutput.Text = "        ";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(154, 257);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(64, 31);
            this.maxLabel.TabIndex = 86;
            this.maxLabel.Text = "Max";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(49, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 100);
            this.label10.TabIndex = 102;
            this.label10.Text = "day3Image";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(155, 132);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(78, 73);
            this.tempLabel.TabIndex = 103;
            this.tempLabel.Text = "C";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(340, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label tempLabel;
    }
}
