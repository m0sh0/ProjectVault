﻿namespace WeatherApp.Tabs
{
    partial class HumidityPage
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
            panel1 = new Panel();
            AirHumiStat = new Label();
            AirHumiLbl = new Label();
            panel2 = new Panel();
            PressureStat = new Label();
            PressureLbl = new Label();
            panel3 = new Panel();
            SeaLvlStat = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.LightSlateGray;
            panel1.Controls.Add(AirHumiStat);
            panel1.Controls.Add(AirHumiLbl);
            panel1.Location = new Point(49, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(471, 199);
            panel1.TabIndex = 0;
            // 
            // AirHumiStat
            // 
            AirHumiStat.FlatStyle = FlatStyle.Flat;
            AirHumiStat.Font = new Font("Bahnschrift Light SemiCondensed", 27F);
            AirHumiStat.ForeColor = Color.AliceBlue;
            AirHumiStat.Location = new Point(66, 117);
            AirHumiStat.Name = "AirHumiStat";
            AirHumiStat.Size = new Size(326, 54);
            AirHumiStat.TabIndex = 1;
            AirHumiStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AirHumiLbl
            // 
            AirHumiLbl.AutoSize = true;
            AirHumiLbl.Font = new Font("Bahnschrift SemiBold", 35F);
            AirHumiLbl.ForeColor = Color.AliceBlue;
            AirHumiLbl.Location = new Point(66, 17);
            AirHumiLbl.Name = "AirHumiLbl";
            AirHumiLbl.Size = new Size(350, 71);
            AirHumiLbl.TabIndex = 0;
            AirHumiLbl.Text = "Air humidity";
            AirHumiLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.LightSlateGray;
            panel2.Controls.Add(PressureStat);
            panel2.Controls.Add(PressureLbl);
            panel2.Location = new Point(49, 242);
            panel2.Name = "panel2";
            panel2.Size = new Size(471, 199);
            panel2.TabIndex = 2;
            // 
            // PressureStat
            // 
            PressureStat.Anchor = AnchorStyles.Top;
            PressureStat.FlatStyle = FlatStyle.Flat;
            PressureStat.Font = new Font("Bahnschrift Light SemiCondensed", 27F);
            PressureStat.ForeColor = Color.AliceBlue;
            PressureStat.Location = new Point(66, 126);
            PressureStat.Name = "PressureStat";
            PressureStat.Size = new Size(350, 54);
            PressureStat.TabIndex = 1;
            PressureStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PressureLbl
            // 
            PressureLbl.AutoSize = true;
            PressureLbl.Font = new Font("Bahnschrift SemiBold", 27F);
            PressureLbl.ForeColor = Color.AliceBlue;
            PressureLbl.Location = new Point(4, 22);
            PressureLbl.Name = "PressureLbl";
            PressureLbl.Size = new Size(472, 54);
            PressureLbl.TabIndex = 0;
            PressureLbl.Text = "Atmospheric pressure";
            PressureLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(SeaLvlStat);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(49, 447);
            panel3.Name = "panel3";
            panel3.Size = new Size(471, 199);
            panel3.TabIndex = 3;
            // 
            // SeaLvlStat
            // 
            SeaLvlStat.FlatStyle = FlatStyle.Flat;
            SeaLvlStat.Font = new Font("Bahnschrift Light SemiCondensed", 27F);
            SeaLvlStat.ForeColor = Color.AliceBlue;
            SeaLvlStat.Location = new Point(98, 130);
            SeaLvlStat.Name = "SeaLvlStat";
            SeaLvlStat.Size = new Size(294, 54);
            SeaLvlStat.TabIndex = 1;
            SeaLvlStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 35F);
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(98, 17);
            label4.Name = "label4";
            label4.Size = new Size(271, 71);
            label4.TabIndex = 0;
            label4.Text = "Sea level";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HumidityPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HumidityPage";
            Size = new Size(572, 692);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label AirHumiLbl;
        private Label AirHumiStat;
        private Panel panel2;
        private Label PressureStat;
        private Label PressureLbl;
        private Panel panel3;
        private Label SeaLvlStat;
        private Label label4;
    }
}
