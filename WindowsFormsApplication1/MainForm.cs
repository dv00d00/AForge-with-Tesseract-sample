using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Imaging.Filters;
using Tesseract;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = @"img\rand.jpg";
            
            var bitmap = AForge.Imaging.Image.FromFile(path);
            this.pictureBox1.Image = bitmap;


            var image = AForge.Imaging.Image.Clone(bitmap, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            var colorFiltering = new ColorFiltering();
            int red1 = 50;
            int red2 = 100;
            int green1 = 50;
            int green2 = 100;
            int bluel = 50;
            int blue2 = 100;
            colorFiltering.Red = new IntRange(red1, red2);
            colorFiltering.Green = new IntRange(green1, green2);
            colorFiltering.Blue = new IntRange(bluel, blue2);

            var simplePosterization = new SimplePosterization
            {
                PosterizationInterval = 100,
                FillingType =  SimplePosterization.PosterizationFillingType.Min,

            };

            var threshold = new Threshold()
            {
                ThresholdValue = 128
            };

            var levelsLinear = new LevelsLinear();


            var grayscale = Grayscale.CommonAlgorithms.RMY;
            var greyscaled = grayscale.Apply(image);
            threshold.ApplyInPlace(greyscaled);
            //Bitmap nImage2 = grayscale.Apply(nImage);

            this.pictureBox2.Image = greyscaled;

            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                engine.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
                var process = engine.Process(greyscaled);
                var text = process.GetText();
                textBox1.Text = text;
            }
        }

        
    }
}
