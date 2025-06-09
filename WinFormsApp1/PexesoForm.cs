using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class PexesoForm : Form
    {
        private AchievementManager _achievementManager;

        private TableLayoutPanel table;
        private List<string> obrazky;
        private PictureBox prvniKlik = null;
        private PictureBox druhyKlik = null;
        private Timer casovac;
        private Random rng = new Random();
        private MainMenu mainMenu;
        private Image zadniStrana;
        private bool jeZamknuto = false;

        public PexesoForm(MainMenu menu, AchievementManager achievementManager)
        {
            mainMenu = menu;
            InitializeComponent();
            zadniStrana = Image.FromFile("obrazky/zadni_strana.png");
            VytvorLayout();
            NactiObrazky();
            RozlozObrazky();
            _achievementManager = achievementManager;
        }

        private void VytvorLayout()
        {
            table = new TableLayoutPanel
            {
                RowCount = 4,
                ColumnCount = 4,
                Dock = DockStyle.Fill
            };

            for (int i = 0; i < 4; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
                table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            }

            Controls.Add(table);
        }

        private void NactiObrazky()
        {
            obrazky = new List<string>();
            for (int i = 1; i <= 8; i++)
            {
                obrazky.Add("obrazky/obrazek" + i + ".png");
                obrazky.Add("obrazky/obrazek" + i + ".png");
            }
            obrazky = obrazky.OrderBy(x => rng.Next()).ToList();
        }

        private void RozlozObrazky()
        {
            int index = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox
                    {
                        Dock = DockStyle.Fill,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = zadniStrana,
                        Tag = obrazky[index]
                    };
                    pic.Click += Pic_Click;
                    table.Controls.Add(pic, j, i);
                    index++;
                }
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            if (jeZamknuto)
                return;

            PictureBox kliknuto = sender as PictureBox;
            if (kliknuto == null || kliknuto.Image == null || kliknuto == prvniKlik)
                return;

            kliknuto.Image = Image.FromFile((string)kliknuto.Tag);

            if (prvniKlik == null)
            {
                prvniKlik = kliknuto;
                return;
            }

            druhyKlik = kliknuto;
            jeZamknuto = true;

            if (prvniKlik.Tag.ToString() == druhyKlik.Tag.ToString())
            {
                var timer = new Timer();
                timer.Interval = 300;
                timer.Tick += (s, ev) =>
                {
                    timer.Stop();
                    prvniKlik = null;
                    druhyKlik = null;
                    jeZamknuto = false;

                    if (VyhralJsi())
                    {
                        _achievementManager.OdemkniAchievement("První výhra!");
                        _achievementManager.UlozitDoSouboru("achievementy.json");
                        MessageBox.Show("Vyhrál jsi!");
                        this.Close();
                        mainMenu.Show();
                    }
                };
                timer.Start();
            }
            else
            {
                casovac = new Timer();
                casovac.Interval = 1000;
                casovac.Tick += Casovac_Tick;
                casovac.Start();
            }
        }

        private void Casovac_Tick(object sender, EventArgs e)
        {
            casovac.Stop();
            prvniKlik.Image = zadniStrana;
            druhyKlik.Image = zadniStrana;
            prvniKlik = null;
            druhyKlik = null;
            jeZamknuto = false;
        }

        private bool VyhralJsi()
        {
            foreach (PictureBox pic in table.Controls)
            {
                if (pic.Image == zadniStrana)
                    return false;
            }
            return true;
        }
    }
}
