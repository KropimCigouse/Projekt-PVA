using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace WinFormsApp1
{
    public partial class FormSeznam : Form
    {
        private readonly AchievementManager _achievementManager;

        public FormSeznam(AchievementManager manager)
        {
            InitializeComponent();
            _achievementManager = manager;


            NaplnitSeznam();
        }

        private void NaplnitSeznam()
        {
            var scrollPanel = new Panel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            Controls.Add(scrollPanel);

            int y = 10;
            foreach (var ach in _achievementManager.GetAllAchievements())
            {
                var label = new Label
                {
                    AutoSize = true,
                    Text = $"{ach.Jmeno} - {(ach.Odemknuty ? "✔️ Odemčen" : "🔒 Neodemčen")}\n{ach.Popis}",
                    Location = new System.Drawing.Point(10, y),
                    MaximumSize = new System.Drawing.Size(scrollPanel.Width - 40, 0)
                };
                scrollPanel.Controls.Add(label);
                y += label.Height + 10;
            }
        }

    }
}
