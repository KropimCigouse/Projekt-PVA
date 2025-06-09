namespace WinFormsApp1
{
    partial class KamenNuzkyPapir
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxVolbaBot = new PictureBox();
            buttonKamen = new Button();
            buttonNuzky = new Button();
            buttonPapir = new Button();
            label1 = new Label();
            buttonHraj = new Button();
            textBoxSkoreKNP = new TextBox();
            textBoxVyhraKNP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVolbaBot).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxVolbaBot
            // 
            pictureBoxVolbaBot.Location = new Point(521, 111);
            pictureBoxVolbaBot.Name = "pictureBoxVolbaBot";
            pictureBoxVolbaBot.Size = new Size(267, 254);
            pictureBoxVolbaBot.TabIndex = 0;
            pictureBoxVolbaBot.TabStop = false;
            // 
            // buttonKamen
            // 
            buttonKamen.FlatStyle = FlatStyle.Flat;
            buttonKamen.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonKamen.Location = new Point(43, 111);
            buttonKamen.Name = "buttonKamen";
            buttonKamen.Size = new Size(91, 38);
            buttonKamen.TabIndex = 1;
            buttonKamen.Text = "Kamen";
            buttonKamen.UseVisualStyleBackColor = true;
            buttonKamen.Click += buttonKamen_Click;
            // 
            // buttonNuzky
            // 
            buttonNuzky.FlatStyle = FlatStyle.Flat;
            buttonNuzky.Font = new Font("Showcard Gothic", 11.25F);
            buttonNuzky.Location = new Point(43, 192);
            buttonNuzky.Name = "buttonNuzky";
            buttonNuzky.Size = new Size(91, 38);
            buttonNuzky.TabIndex = 2;
            buttonNuzky.Text = "Nuzky";
            buttonNuzky.UseVisualStyleBackColor = true;
            buttonNuzky.Click += buttonNuzky_Click;
            // 
            // buttonPapir
            // 
            buttonPapir.FlatStyle = FlatStyle.Flat;
            buttonPapir.Font = new Font("Showcard Gothic", 11.25F);
            buttonPapir.Location = new Point(43, 267);
            buttonPapir.Name = "buttonPapir";
            buttonPapir.Size = new Size(91, 38);
            buttonPapir.TabIndex = 3;
            buttonPapir.Text = "Papir";
            buttonPapir.UseVisualStyleBackColor = true;
            buttonPapir.Click += buttonPapir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(540, 51);
            label1.MinimumSize = new Size(130, 30);
            label1.Name = "label1";
            label1.Size = new Size(154, 30);
            label1.TabIndex = 4;
            label1.Text = "Volba Robota";
            // 
            // buttonHraj
            // 
            buttonHraj.BackColor = SystemColors.GradientActiveCaption;
            buttonHraj.FlatStyle = FlatStyle.Flat;
            buttonHraj.Font = new Font("Showcard Gothic", 11.25F);
            buttonHraj.Location = new Point(274, 46);
            buttonHraj.Margin = new Padding(0);
            buttonHraj.Name = "buttonHraj";
            buttonHraj.Size = new Size(117, 37);
            buttonHraj.TabIndex = 5;
            buttonHraj.Text = "Hrát";
            buttonHraj.UseVisualStyleBackColor = false;
            buttonHraj.Click += buttonHraj_Click;
            // 
            // textBoxSkoreKNP
            // 
            textBoxSkoreKNP.BackColor = SystemColors.Info;
            textBoxSkoreKNP.BorderStyle = BorderStyle.None;
            textBoxSkoreKNP.Font = new Font("Showcard Gothic", 11.25F);
            textBoxSkoreKNP.Location = new Point(12, 12);
            textBoxSkoreKNP.Name = "textBoxSkoreKNP";
            textBoxSkoreKNP.Size = new Size(100, 19);
            textBoxSkoreKNP.TabIndex = 6;
            textBoxSkoreKNP.Text = "Skóre: 0";
            // 
            // textBoxVyhraKNP
            // 
            textBoxVyhraKNP.BackColor = SystemColors.Info;
            textBoxVyhraKNP.BorderStyle = BorderStyle.None;
            textBoxVyhraKNP.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxVyhraKNP.Location = new Point(221, 189);
            textBoxVyhraKNP.MinimumSize = new Size(200, 85);
            textBoxVyhraKNP.Name = "textBoxVyhraKNP";
            textBoxVyhraKNP.Size = new Size(239, 85);
            textBoxVyhraKNP.TabIndex = 7;
            textBoxVyhraKNP.TextAlign = HorizontalAlignment.Center;
            // 
            // KamenNuzkyPapir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxVyhraKNP);
            Controls.Add(textBoxSkoreKNP);
            Controls.Add(buttonHraj);
            Controls.Add(label1);
            Controls.Add(buttonPapir);
            Controls.Add(buttonNuzky);
            Controls.Add(buttonKamen);
            Controls.Add(pictureBoxVolbaBot);
            Name = "KamenNuzkyPapir";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxVolbaBot).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxVolbaBot;
        private Button buttonKamen;
        private TextBox textBox1;
        private Button buttonNuzky;
        private Button buttonPapir;
        private Label label1;
        private Button buttonHraj;
        private TextBox textBoxSkoreKNP;
        private TextBox textBoxVyhraKNP;
    }
}