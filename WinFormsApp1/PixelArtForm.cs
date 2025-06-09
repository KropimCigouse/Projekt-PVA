using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PixelArtForm: Form
    {
        private MainMenu mainMenu;
        private TableLayoutPanel grid;
        private Color aktualniBarva = Color.Black;
        private int velikost = 16;

        public PixelArtForm(MainMenu menu)
        {
            mainMenu = menu;
            this.Text = "Pixel Art Kreslení";
            this.Width = 800;
            this.Height = 600;

            VytvorPanelNastroju();
            VytvorMrizku();
            InitializeComponent();
        }

        private void VytvorPanelNastroju()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Top;
            panel.Height = 50;

            Button btnCerna = new Button { BackColor = Color.Black, Width = 40};
            btnCerna.Click += (s, e) => aktualniBarva = Color.Black;

            Button btnCervena = new Button { BackColor = Color.Red, Width = 40 };
            btnCervena.Click += (s, e) => aktualniBarva = Color.Red;

            Button btnZelena = new Button { BackColor = Color.Green, Width = 40 };
            btnZelena.Click += (s, e) => aktualniBarva = Color.Green;

            Button btnZluta = new Button { BackColor = Color.Yellow, Width = 40 };
            btnZluta.Click += (s, e) => aktualniBarva = Color.Yellow;

            Button btnModra = new Button { BackColor = Color.Blue, Width = 40 };
            btnModra.Click += (s, e) => aktualniBarva = Color.Blue;

            Button btnGuma = new Button { Text = "Guma"};
            btnGuma.Click += (s, e) => aktualniBarva = Color.White;

            Button btnZpatky = new Button { Text = "Menu" };
            btnZpatky.Click += (s, e) => { this.Close(); mainMenu.Show(); };

            Button btnUlozit = new Button { Text = "Uložit" };
            btnUlozit.Click += (s, e) => UlozitObrazek();

            panel.Controls.AddRange(new Control[] { btnCerna, btnCervena, btnZelena, btnZluta, btnModra, btnGuma, btnUlozit, btnZpatky });
            this.Controls.Add(panel);
        }

        private void VytvorMrizku()
        {
            grid = new TableLayoutPanel();
            grid.Dock = DockStyle.Fill;
            grid.ColumnCount = velikost;
            grid.RowCount = velikost;

            for (int i = 0; i < velikost; i++)
            {
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / velikost));
                grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / velikost));
            }

            for (int i = 0; i < velikost * velikost; i++)
            {
                Panel pixel = new Panel();
                pixel.Dock = DockStyle.Fill;
                pixel.BackColor = Color.White;
                pixel.Margin = new Padding(1);
                pixel.Click += (sender, e) => { pixel.BackColor = aktualniBarva; };
                grid.Controls.Add(pixel);
            }

            this.Controls.Add(grid);
        }

        private void BtnGuma_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UlozitObrazek()
        {
            Bitmap bmp = new Bitmap(grid.Width, grid.Height);
            grid.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png";
            sfd.Title = "Uložit obrázek";
            sfd.FileName = "pixelart.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName, ImageFormat.Png);
                MessageBox.Show("Uloženo úspěšně.");
            }
        }
    }
}
