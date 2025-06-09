namespace WinFormsApp1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            buttonPexeso = new Button();
            buttonPixelArt = new Button();
            buttonRPS = new Button();
            buttonAchievementy = new Button();
            SuspendLayout();
            // 
            // buttonPexeso
            // 
            buttonPexeso.AccessibleName = "";
            buttonPexeso.BackColor = Color.Orange;
            buttonPexeso.FlatStyle = FlatStyle.Flat;
            buttonPexeso.Font = new Font("Showcard Gothic", 14.25F);
            buttonPexeso.Location = new Point(35, 22);
            buttonPexeso.Name = "buttonPexeso";
            buttonPexeso.Size = new Size(196, 56);
            buttonPexeso.TabIndex = 0;
            buttonPexeso.Text = "Pexeso";
            buttonPexeso.UseVisualStyleBackColor = false;
            buttonPexeso.Click += buttonPexeso_Click;
            // 
            // buttonPixelArt
            // 
            buttonPixelArt.BackColor = Color.Orange;
            buttonPixelArt.FlatStyle = FlatStyle.Flat;
            buttonPixelArt.Font = new Font("Showcard Gothic", 14.25F);
            buttonPixelArt.Location = new Point(574, 22);
            buttonPixelArt.Name = "buttonPixelArt";
            buttonPixelArt.Size = new Size(169, 56);
            buttonPixelArt.TabIndex = 1;
            buttonPixelArt.Text = "Pixel Art";
            buttonPixelArt.UseVisualStyleBackColor = false;
            buttonPixelArt.Click += buttonPixelArt_Click;
            // 
            // buttonRPS
            // 
            buttonRPS.BackColor = Color.Orange;
            buttonRPS.FlatStyle = FlatStyle.Flat;
            buttonRPS.Font = new Font("Showcard Gothic", 14.25F);
            buttonRPS.Location = new Point(276, 22);
            buttonRPS.Name = "buttonRPS";
            buttonRPS.Size = new Size(229, 56);
            buttonRPS.TabIndex = 3;
            buttonRPS.Text = "Kámen, nužky, papír";
            buttonRPS.UseVisualStyleBackColor = false;
            buttonRPS.Click += buttonRPS_Click;
            // 
            // buttonAchievementy
            // 
            buttonAchievementy.AccessibleRole = AccessibleRole.None;
            buttonAchievementy.BackColor = Color.Orange;
            buttonAchievementy.FlatStyle = FlatStyle.Flat;
            buttonAchievementy.Font = new Font("Showcard Gothic", 14.25F);
            buttonAchievementy.Location = new Point(276, 392);
            buttonAchievementy.Name = "buttonAchievementy";
            buttonAchievementy.Size = new Size(229, 46);
            buttonAchievementy.TabIndex = 4;
            buttonAchievementy.Text = "Achievementy";
            buttonAchievementy.UseVisualStyleBackColor = false;
            buttonAchievementy.Click += buttonAchievementy_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonAchievementy);
            Controls.Add(buttonRPS);
            Controls.Add(buttonPixelArt);
            Controls.Add(buttonPexeso);
            Name = "MainMenu";
            Text = "Form1";
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPexeso;
        private Button buttonPixelArt;
        private Button buttonRPS;
        private Button buttonAchievementy;



    }
}
