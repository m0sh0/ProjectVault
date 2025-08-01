﻿namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TitleLbl = new Label();
            InputLbl = new TextBox();
            HintLbl = new Label();
            SearchBtn = new Button();
            CloseBtn = new Button();
            CloseButton = new Button();
            ClearBtn = new Button();
            TempBox = new Label();
            MaxTempLbl = new Label();
            MinTempLbl = new Label();
            CurrentTempLbl = new Label();
            FeelsLikeLbl = new Label();
            label1 = new Label();
            CountruLbl = new Label();
            label2 = new Label();
            WindSpeedLbl = new Label();
            label3 = new Label();
            NameLbl = new Label();
            CurrentTempStat = new Label();
            MaxTempStat = new Label();
            MinTempStat = new Label();
            FeelsLikeStat = new Label();
            CountryStat = new Label();
            WindSpeedStat = new Label();
            FahrenheitCheck = new CheckBox();
            CelsiusCheck = new CheckBox();
            HumiPageButton = new Button();
            SuspendLayout();
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.BackColor = Color.Transparent;
            TitleLbl.Font = new Font("Bahnschrift SemiBold Condensed", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLbl.ForeColor = Color.LightSlateGray;
            TitleLbl.Location = new Point(150, 22);
            TitleLbl.Margin = new Padding(0);
            TitleLbl.MaximumSize = new Size(10000, 10000);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(569, 115);
            TitleLbl.TabIndex = 0;
            TitleLbl.Tag = "TitleLbl";
            TitleLbl.Text = "Current Weather";
            TitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputLbl
            // 
            InputLbl.AcceptsReturn = true;
            InputLbl.BackColor = SystemColors.ButtonHighlight;
            InputLbl.BorderStyle = BorderStyle.FixedSingle;
            InputLbl.Cursor = Cursors.IBeam;
            InputLbl.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputLbl.ForeColor = Color.LightSlateGray;
            InputLbl.Location = new Point(318, 171);
            InputLbl.Name = "InputLbl";
            InputLbl.PlaceholderText = "City name";
            InputLbl.Size = new Size(182, 33);
            InputLbl.TabIndex = 1;
            // 
            // HintLbl
            // 
            HintLbl.AutoSize = true;
            HintLbl.BackColor = Color.Transparent;
            HintLbl.Font = new Font("Bahnschrift Light Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HintLbl.ForeColor = Color.LightSlateGray;
            HintLbl.Location = new Point(317, 207);
            HintLbl.Margin = new Padding(0);
            HintLbl.MaximumSize = new Size(10000, 10000);
            HintLbl.Name = "HintLbl";
            HintLbl.Size = new Size(230, 23);
            HintLbl.TabIndex = 2;
            HintLbl.Tag = "TitleLbl";
            HintLbl.Text = "Enter city name to see the weather";
            HintLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.LightSlateGray;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Image = (Image)resources.GetObject("SearchBtn.Image");
            SearchBtn.Location = new Point(550, 167);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(46, 44);
            SearchBtn.TabIndex = 3;
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.AliceBlue;
            CloseBtn.FlatStyle = FlatStyle.Flat;
            CloseBtn.ForeColor = Color.AliceBlue;
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(804, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(38, 40);
            CloseBtn.TabIndex = 4;
            CloseBtn.UseVisualStyleBackColor = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.AliceBlue;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.AliceBlue;
            CloseButton.Image = Properties.Resources.CloseButton;
            CloseButton.Location = new Point(848, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(38, 40);
            CloseButton.TabIndex = 5;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.IndianRed;
            ClearBtn.FlatStyle = FlatStyle.Flat;
            ClearBtn.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearBtn.ForeColor = SystemColors.Control;
            ClearBtn.Location = new Point(502, 171);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(32, 33);
            ClearBtn.TabIndex = 6;
            ClearBtn.Text = "X";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // TempBox
            // 
            TempBox.BackColor = Color.LightSlateGray;
            TempBox.Location = new Point(142, 284);
            TempBox.Name = "TempBox";
            TempBox.Size = new Size(262, 229);
            TempBox.TabIndex = 7;
            TempBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaxTempLbl
            // 
            MaxTempLbl.AutoSize = true;
            MaxTempLbl.BackColor = Color.LightSlateGray;
            MaxTempLbl.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxTempLbl.ForeColor = Color.AliceBlue;
            MaxTempLbl.Location = new Point(150, 350);
            MaxTempLbl.Name = "MaxTempLbl";
            MaxTempLbl.Size = new Size(95, 39);
            MaxTempLbl.TabIndex = 8;
            MaxTempLbl.Text = "Max t° :";
            MaxTempLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MinTempLbl
            // 
            MinTempLbl.AutoSize = true;
            MinTempLbl.BackColor = Color.LightSlateGray;
            MinTempLbl.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinTempLbl.ForeColor = Color.AliceBlue;
            MinTempLbl.Location = new Point(150, 398);
            MinTempLbl.Name = "MinTempLbl";
            MinTempLbl.Size = new Size(88, 39);
            MinTempLbl.TabIndex = 9;
            MinTempLbl.Text = "Min t° :";
            MinTempLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CurrentTempLbl
            // 
            CurrentTempLbl.AutoSize = true;
            CurrentTempLbl.BackColor = Color.LightSlateGray;
            CurrentTempLbl.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentTempLbl.ForeColor = Color.AliceBlue;
            CurrentTempLbl.Location = new Point(150, 299);
            CurrentTempLbl.Name = "CurrentTempLbl";
            CurrentTempLbl.Size = new Size(131, 39);
            CurrentTempLbl.TabIndex = 10;
            CurrentTempLbl.Text = "Current t° :";
            CurrentTempLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeelsLikeLbl
            // 
            FeelsLikeLbl.AutoSize = true;
            FeelsLikeLbl.BackColor = Color.LightSlateGray;
            FeelsLikeLbl.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeelsLikeLbl.ForeColor = Color.AliceBlue;
            FeelsLikeLbl.Location = new Point(148, 451);
            FeelsLikeLbl.Name = "FeelsLikeLbl";
            FeelsLikeLbl.Size = new Size(130, 39);
            FeelsLikeLbl.TabIndex = 11;
            FeelsLikeLbl.Text = "Feels like :";
            FeelsLikeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.LightSlateGray;
            label1.Location = new Point(407, 285);
            label1.Name = "label1";
            label1.Size = new Size(160, 53);
            label1.TabIndex = 12;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CountruLbl
            // 
            CountruLbl.AutoSize = true;
            CountruLbl.BackColor = Color.LightSlateGray;
            CountruLbl.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CountruLbl.ForeColor = Color.AliceBlue;
            CountruLbl.Location = new Point(410, 293);
            CountruLbl.Name = "CountruLbl";
            CountruLbl.Size = new Size(109, 39);
            CountruLbl.TabIndex = 13;
            CountruLbl.Text = "Country :";
            CountruLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSlateGray;
            label2.Location = new Point(408, 350);
            label2.Name = "label2";
            label2.Size = new Size(341, 163);
            label2.TabIndex = 14;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WindSpeedLbl
            // 
            WindSpeedLbl.AutoSize = true;
            WindSpeedLbl.BackColor = Color.LightSlateGray;
            WindSpeedLbl.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WindSpeedLbl.ForeColor = Color.AliceBlue;
            WindSpeedLbl.Location = new Point(412, 410);
            WindSpeedLbl.Name = "WindSpeedLbl";
            WindSpeedLbl.Size = new Size(148, 39);
            WindSpeedLbl.TabIndex = 15;
            WindSpeedLbl.Text = "Wind speed :";
            WindSpeedLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.LightSlateGray;
            label3.Location = new Point(573, 285);
            label3.Name = "label3";
            label3.Size = new Size(178, 53);
            label3.TabIndex = 16;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.BackColor = Color.LightSlateGray;
            NameLbl.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameLbl.ForeColor = Color.AliceBlue;
            NameLbl.Location = new Point(614, 294);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(77, 39);
            NameLbl.TabIndex = 17;
            NameLbl.Text = "Name";
            NameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CurrentTempStat
            // 
            CurrentTempStat.BackColor = Color.LightSlateGray;
            CurrentTempStat.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentTempStat.ForeColor = Color.AliceBlue;
            CurrentTempStat.Location = new Point(291, 299);
            CurrentTempStat.MaximumSize = new Size(110, 36);
            CurrentTempStat.Name = "CurrentTempStat";
            CurrentTempStat.Size = new Size(110, 36);
            CurrentTempStat.TabIndex = 18;
            CurrentTempStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MaxTempStat
            // 
            MaxTempStat.BackColor = Color.LightSlateGray;
            MaxTempStat.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaxTempStat.ForeColor = Color.AliceBlue;
            MaxTempStat.Location = new Point(255, 350);
            MaxTempStat.MaximumSize = new Size(130, 36);
            MaxTempStat.Name = "MaxTempStat";
            MaxTempStat.Size = new Size(130, 36);
            MaxTempStat.TabIndex = 19;
            MaxTempStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MinTempStat
            // 
            MinTempStat.BackColor = Color.LightSlateGray;
            MinTempStat.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinTempStat.ForeColor = Color.AliceBlue;
            MinTempStat.Location = new Point(247, 398);
            MinTempStat.MaximumSize = new Size(130, 36);
            MinTempStat.Name = "MinTempStat";
            MinTempStat.Size = new Size(130, 36);
            MinTempStat.TabIndex = 20;
            MinTempStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeelsLikeStat
            // 
            FeelsLikeStat.BackColor = Color.LightSlateGray;
            FeelsLikeStat.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FeelsLikeStat.ForeColor = Color.AliceBlue;
            FeelsLikeStat.Location = new Point(289, 451);
            FeelsLikeStat.MaximumSize = new Size(130, 36);
            FeelsLikeStat.Name = "FeelsLikeStat";
            FeelsLikeStat.Size = new Size(110, 36);
            FeelsLikeStat.TabIndex = 21;
            FeelsLikeStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CountryStat
            // 
            CountryStat.BackColor = Color.LightSlateGray;
            CountryStat.Font = new Font("Bahnschrift Condensed", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CountryStat.ForeColor = Color.AliceBlue;
            CountryStat.Location = new Point(521, 296);
            CountryStat.Name = "CountryStat";
            CountryStat.Size = new Size(46, 34);
            CountryStat.TabIndex = 22;
            CountryStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WindSpeedStat
            // 
            WindSpeedStat.BackColor = Color.LightSlateGray;
            WindSpeedStat.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WindSpeedStat.ForeColor = Color.AliceBlue;
            WindSpeedStat.Location = new Point(566, 410);
            WindSpeedStat.Name = "WindSpeedStat";
            WindSpeedStat.Size = new Size(150, 36);
            WindSpeedStat.TabIndex = 23;
            WindSpeedStat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FahrenheitCheck
            // 
            FahrenheitCheck.AutoSize = true;
            FahrenheitCheck.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FahrenheitCheck.ForeColor = Color.LightSlateGray;
            FahrenheitCheck.Location = new Point(42, 9);
            FahrenheitCheck.Name = "FahrenheitCheck";
            FahrenheitCheck.Size = new Size(60, 46);
            FahrenheitCheck.TabIndex = 25;
            FahrenheitCheck.Text = "F°";
            FahrenheitCheck.UseVisualStyleBackColor = true;
            FahrenheitCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // CelsiusCheck
            // 
            CelsiusCheck.AutoSize = true;
            CelsiusCheck.Checked = true;
            CelsiusCheck.CheckState = CheckState.Checked;
            CelsiusCheck.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CelsiusCheck.ForeColor = Color.LightSlateGray;
            CelsiusCheck.Location = new Point(42, 61);
            CelsiusCheck.Name = "CelsiusCheck";
            CelsiusCheck.Size = new Size(62, 46);
            CelsiusCheck.TabIndex = 26;
            CelsiusCheck.Text = "C°";
            CelsiusCheck.UseVisualStyleBackColor = true;
            CelsiusCheck.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // HumiPageButton
            // 
            HumiPageButton.FlatStyle = FlatStyle.Flat;
            HumiPageButton.Font = new Font("Bahnschrift Condensed", 15F);
            HumiPageButton.ForeColor = Color.LightSlateGray;
            HumiPageButton.Location = new Point(823, 289);
            HumiPageButton.Margin = new Padding(3, 2, 3, 2);
            HumiPageButton.Name = "HumiPageButton";
            HumiPageButton.Size = new Size(101, 39);
            HumiPageButton.TabIndex = 27;
            HumiPageButton.Text = "Other statistics";
            HumiPageButton.UseVisualStyleBackColor = true;
            HumiPageButton.Click += HumiPageButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(923, 519);
            Controls.Add(HumiPageButton);
            Controls.Add(CelsiusCheck);
            Controls.Add(FahrenheitCheck);
            Controls.Add(WindSpeedStat);
            Controls.Add(CountryStat);
            Controls.Add(FeelsLikeStat);
            Controls.Add(MinTempStat);
            Controls.Add(MaxTempStat);
            Controls.Add(CurrentTempStat);
            Controls.Add(NameLbl);
            Controls.Add(label3);
            Controls.Add(WindSpeedLbl);
            Controls.Add(label2);
            Controls.Add(CountruLbl);
            Controls.Add(label1);
            Controls.Add(FeelsLikeLbl);
            Controls.Add(CurrentTempLbl);
            Controls.Add(MinTempLbl);
            Controls.Add(MaxTempLbl);
            Controls.Add(TempBox);
            Controls.Add(ClearBtn);
            Controls.Add(CloseButton);
            Controls.Add(CloseBtn);
            Controls.Add(SearchBtn);
            Controls.Add(HintLbl);
            Controls.Add(InputLbl);
            Controls.Add(TitleLbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label TitleLbl;
        public TextBox InputLbl;
        public Label HintLbl;
        private Button SearchBtn;
        private Button CloseBtn;
        private Button CloseButton;
        private Button ClearBtn;
        private Label TempBox;
        private Label MaxTempLbl;
        private Label MinTempLbl;
        private Label CurrentTempLbl;
        private Label FeelsLikeLbl;
        private Label label1;
        private Label CountruLbl;
        private Label label2;
        private Label WindSpeedLbl;
        private Label label3;
        private Label NameLbl;
        private Label CurrentTempStat;
        private Label MaxTempStat;
        private Label MinTempStat;
        private Label FeelsLikeStat;
        private Label CountryStat;
        private Label WindSpeedStat;
        private CheckBox FahrenheitCheck;
        private CheckBox CelsiusCheck;
        private Button HumiPageButton;
    }
}
