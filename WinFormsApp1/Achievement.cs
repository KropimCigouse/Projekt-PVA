using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class Achievement
    {
        public string Jmeno { get; set; }
        public string Popis { get; set; }
        public bool Odemknuty { get; set; }

        public Achievement(string jmeno, string popis)
        {
            Jmeno = jmeno;
            Popis = popis;
            Odemknuty = false;
        }

        public bool Odemknout()
        {
            if (!Odemknuty)
            {
                Odemknuty = true;
                return true;
            }
            return false;
        }
    }


    public interface IOznamovacAchievementu
    {
        void Oznamit(Achievement achievement);
    }

    public class MessageBoxOznamovac : IOznamovacAchievementu
    {
        public void Oznamit(Achievement achievement)
        {
            MessageBox.Show($"Achievement odemčen:\n{achievement.Jmeno}\n{achievement.Popis}", "Achievement!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public class AchievementManager
    {
        private readonly List<Achievement> _achievementy;
        private readonly IOznamovacAchievementu _oznamovac;

        public AchievementManager(IOznamovacAchievementu oznamovac)
        {
            _oznamovac = oznamovac;
            _achievementy = new List<Achievement>();
        }

        public void PridatAchievement(Achievement achievement)
        {
            _achievementy.Add(achievement);
        }

        public void Zvuk()
        {
            SoundPlayer player = new SoundPlayer(@"zvuky/achievement.wav");
            player.Play();
        }

        public void OdemkniAchievement(string jmeno)
        {
            var achievement = _achievementy.FirstOrDefault(a => a.Jmeno == jmeno);
            if (achievement != null && achievement.Odemknout())
            {
                Zvuk();
                _oznamovac.Oznamit(achievement);
                
            }
        }

        public void UlozitDoSouboru(string cesta)
        {
            var json = JsonSerializer.Serialize(_achievementy);
            File.WriteAllText(cesta, json);
        }

        public void NacistZeSouboru(string cesta)
        {
            if (File.Exists(cesta))
            {
                var json = File.ReadAllText(cesta);
                var nactene = JsonSerializer.Deserialize<List<Achievement>>(json);
                if (nactene != null)
                {
                    _achievementy.Clear();
                    _achievementy.AddRange(nactene);
                }
            }
        }

        public IEnumerable<Achievement> GetAllAchievements() => _achievementy.AsReadOnly();
    }

    
}
