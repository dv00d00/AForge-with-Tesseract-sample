using System;
using System.Windows.Forms;
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

        private void OnLoad(object sender, EventArgs e)
        {
            const string path = @"img\rand.jpg";
            
            var bitmap = AForge.Imaging.Image.FromFile(path);

            this.sourcePic.Image = bitmap;

            var image = AForge.Imaging.Image.Clone(bitmap, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            var threshold = new Threshold { ThresholdValue = 128 };

            var greyscaled = Grayscale.CommonAlgorithms.RMY.Apply(image);

            threshold.ApplyInPlace(greyscaled);

            this.processedPic.Image = greyscaled;

            using (var engine = new TesseractEngine(@"./tessdata", "eng"))
            {
                engine.SetVariable("tessedit_char_whitelist", "0123456789"); // If digit only
                var process = engine.Process(greyscaled);
                var text = process.GetText();
                recognizedText.Text = text;
            }
        }
    }
}
