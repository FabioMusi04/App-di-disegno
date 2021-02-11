using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disegnoapp
{
    public partial class Form1 : Form
    {
        public Point Inizio = new Point();
        public Point Fine = new Point();
        public Pen penna;
        bool disegna = false;
        string colori;
        Graphics grafica;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            Generafunzionivariabili();
        }

        void Generafunzionivariabili()
        {
            this.Location = new Point(0, 0);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            grafica = Fogliodidisegno.CreateGraphics();
            Txtgrandezze.Text = "8";
            colori = "#000000";
            txt_color.Text = colori;
            Creafogliodisegno();
        }
        void Creafogliodisegno()
        {
            bmp = new Bitmap(Fogliodidisegno.Width, Fogliodidisegno.Height);
            grafica = Graphics.FromImage(bmp);
            Fogliodidisegno.BackgroundImage = bmp;
            Fogliodidisegno.BackgroundImageLayout = ImageLayout.None;
        }

        private void Fogliodidisegno_MouseDown(object sender, MouseEventArgs e)
        {
            disegna = true;

            Inizio = e.Location;

            int size;

            if (Txtgrandezze.Text == "")
            {
                size = 8;
            }
            else
            {
                size = Convert.ToInt32(Txtgrandezze.Text);
            }

            Color newColor = ColorTranslator.FromHtml(colori);
            penna = new Pen(newColor, size);
            penna.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void Fogliodidisegno_MouseMove(object sender, MouseEventArgs e)
        {
            if (disegna)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Fine = e.Location;
                    grafica.DrawLine(penna, Inizio, Fine);
                    Inizio = Fine;
                    Fogliodidisegno.Invalidate();
                }
            }
        }

        private void Fogliodidisegno_MouseUp(object sender, MouseEventArgs e)
        {
            disegna = false;
        }

        private void Ripulisci_Click(object sender, EventArgs e)
        {
            Creafogliodisegno();
        }

        private void ColoriBTN_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                colori = "#" + (cd.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                txt_color.Text = colori;
            }
        }

        private void SalvaBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files| *.png|jpeg files| *.jpg|bitmaps | *.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (System.IO.File.Exists(s.FileName))
                {
                    System.IO.File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }
        }
    }
}
