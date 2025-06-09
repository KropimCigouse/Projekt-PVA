using System;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class KamenNuzkyPapir : Form
    {

        private string volbaUZ = "";
        private int pocetVyher = 0;

        private AchievementManager _achievementManager;

        public KamenNuzkyPapir(AchievementManager achievementManager)
        {
            InitializeComponent();
            _achievementManager = achievementManager;
        }


        private void buttonKamen_Click(object sender, EventArgs e)
        {
            volbaUZ = "kamen";
            buttonKamen.BackColor = Color.LimeGreen;
            buttonNuzky.BackColor = SystemColors.Info;
            buttonPapir.BackColor = SystemColors.Info;
        }

        private void buttonNuzky_Click(object sender, EventArgs e)
        {
            volbaUZ = "nuzky";
            buttonNuzky.BackColor = Color.LimeGreen;
            buttonKamen.BackColor = SystemColors.Info;
            buttonPapir.BackColor = SystemColors.Info;
        }

        private void buttonPapir_Click(object sender, EventArgs e)
        {
            volbaUZ = "papir";
            buttonPapir.BackColor = Color.LimeGreen;
            buttonKamen.BackColor = SystemColors.Info;
            buttonNuzky.BackColor = SystemColors.Info;

        }

        private void ZvukWin()
        {
            SoundPlayer player = new SoundPlayer(@"zvuky/win.wav");
            player.Play();
        }

        private void buttonHraj_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int nahoda = random.Next(1, 4);
            string volba = "";
            switch (nahoda)
            {
                case 1:
                    volba = "kamen";
                    pictureBoxVolbaBot.Image = System.Drawing.Image.FromFile("rock.png");
                    if (volbaUZ == "kamen")
                    {
                        textBoxVyhraKNP.Text = "Remíza!";
                    }
                    else if (volbaUZ == "papir")
                    {
                        ZvukWin();
                        textBoxVyhraKNP.Text = "Vyhrál jsi!";
                        pocetVyher++;
                        textBoxSkoreKNP.Text = $"Skore: {pocetVyher}";
                        _achievementManager.OdemkniAchievement("Papers, Please!");
                        _achievementManager.UlozitDoSouboru("achievementy.json");

                    }
                    else if (volbaUZ == "nuzky")
                    {
                        textBoxVyhraKNP.Text = "Prohrál jsi!";
                        pocetVyher--;
                        textBoxSkoreKNP.Text = $"Skore: {pocetVyher}";
                    }
                    else
                    {
                        textBoxVyhraKNP.Text = "Neplatná volba";
                    }
                    break;




                case 2:
                    volba = "nuzky";
                    pictureBoxVolbaBot.Image = System.Drawing.Image.FromFile("scissor.png");
                    if (volbaUZ == "kamen")
                    {
                        ZvukWin();
                        textBoxVyhraKNP.Text = "Vyhrál jsi!";
                        pocetVyher++;
                        textBoxSkoreKNP.Text = $"Skore: {pocetVyher}";
                        _achievementManager.OdemkniAchievement("Rock and Stone!");
                        _achievementManager.UlozitDoSouboru("achievementy.json");
                    }
                    else if (volbaUZ == "papir")
                    {
                        textBoxVyhraKNP.Text = "Prohrál jsi!";
                        pocetVyher--;
                        textBoxSkoreKNP.Text = $"Skore: {pocetVyher}";
                    }
                    else if (volbaUZ == "nuzky")
                    {
                        textBoxVyhraKNP.Text = "Remíza!";
                    }
                    else
                    {
                        textBoxVyhraKNP.Text = "Neplatná volba";
                    }
                    break;
                case 3:

                    volba = "papir";
                    pictureBoxVolbaBot.Image = System.Drawing.Image.FromFile("paper.png");
                    if (volbaUZ == "kamen")
                    {
                        textBoxVyhraKNP.Text = "Prohrál jsi!";
                        pocetVyher--;
                        textBoxSkoreKNP.Text = $"Skore: {pocetVyher}";

                    }
                    else if (volbaUZ == "papir")
                    {
                        textBoxVyhraKNP.Text = "Remíza!";
                    }
                    else if (volbaUZ == "nuzky")
                    {
                        ZvukWin();
                        textBoxVyhraKNP.Text = "Vyhrál jsi!";
                        pocetVyher++;
                        textBoxSkoreKNP.Text = $"Skore: {pocetVyher}";
                        _achievementManager.OdemkniAchievement("Scissors!");
                        _achievementManager.UlozitDoSouboru("achievementy.json");
                    }
                    else
                    {
                        textBoxVyhraKNP.Text = "Neplatná volba";
                    }
                    break;
                default:
                    textBoxVyhraKNP.Text = "Generace selhala";
                    break;

            }

            if (pocetVyher == 15)
            {
                _achievementManager.OdemkniAchievement("15 Skore!");
                _achievementManager.UlozitDoSouboru("achievementy.json");
            }

        }
    }
}

