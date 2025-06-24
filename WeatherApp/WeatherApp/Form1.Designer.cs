namespace WeatherApp
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
            textBox1 = new TextBox();
            HintLbl = new Label();
            SearchBtn = new Button();
            SuspendLayout();
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.BackColor = Color.Transparent;
            TitleLbl.Font = new Font("Bahnschrift SemiBold Condensed", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLbl.ForeColor = Color.LightSlateGray;
            TitleLbl.Location = new Point(226, 9);
            TitleLbl.Margin = new Padding(0);
            TitleLbl.MaximumSize = new Size(10000, 10000);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(445, 115);
            TitleLbl.TabIndex = 0;
            TitleLbl.Tag = "TitleLbl";
            TitleLbl.Text = "Weather app";
            TitleLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.LightSlateGray;
            textBox1.Location = new Point(318, 171);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "City name";
            textBox1.Size = new Size(220, 33);
            textBox1.TabIndex = 1;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(905, 543);
            Controls.Add(SearchBtn);
            Controls.Add(HintLbl);
            Controls.Add(textBox1);
            Controls.Add(TitleLbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label TitleLbl;
        public TextBox textBox1;
        public Label HintLbl;
        private Button SearchBtn;
    }
}
