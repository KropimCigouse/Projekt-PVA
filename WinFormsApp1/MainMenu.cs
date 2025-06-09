namespace WinFormsApp1
{
    public partial class MainMenu : Form
    {
        private AchievementManager _achievementManager;
        
        public MainMenu()
        {
            InitializeComponent();

            _achievementManager = new AchievementManager(new MessageBoxOznamovac());


        }

        private void buttonRPS_Click(object sender, EventArgs e)
        {
            KamenNuzkyPapir KamenNuzkyPapir = new KamenNuzkyPapir(_achievementManager);
            this.Hide();
            KamenNuzkyPapir.ShowDialog();
            this.Show();


        }

        private void buttonAchievementy_Click(object sender, EventArgs e)
        {
            FormSeznam seznam = new FormSeznam(_achievementManager);
            this.Hide();
            seznam.ShowDialog();
            this.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            _achievementManager.PridatAchievement(new Achievement("Rock and Stone!", "Vyhraj s kamenem."));
            _achievementManager.PridatAchievement(new Achievement("Papers, Please!", "Vyhraj s papírem."));
            _achievementManager.PridatAchievement(new Achievement("Scissors!", "Vyhraj s nůžkama."));
            _achievementManager.PridatAchievement(new Achievement("15 Skore!", "Dosáhni 15 Skore"));
            _achievementManager.PridatAchievement(new Achievement("První výhra!", "Vyhraj 1. hru pexesa."));
            _achievementManager.NacistZeSouboru("achievementy.json");
        }

        private void buttonPixelArt_Click(object sender, EventArgs e)
        {
            PixelArtForm pixelArt = new PixelArtForm(this);
            this.Hide();
            pixelArt.ShowDialog();
            this.Show();
        }

        private void buttonPexeso_Click(object sender, EventArgs e)
        {
            PexesoForm pexeso = new PexesoForm(this, _achievementManager);
            this.Hide();
            pexeso.ShowDialog();
            this.Show();
            

        }
    }

}
