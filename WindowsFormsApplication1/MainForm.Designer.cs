namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.sourcePic = new System.Windows.Forms.PictureBox();
            this.processedPic = new System.Windows.Forms.PictureBox();
            this.recognizedText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.sourcePic.Location = new System.Drawing.Point(12, 12);
            this.sourcePic.Name = "sourcePic";
            this.sourcePic.Size = new System.Drawing.Size(207, 90);
            this.sourcePic.TabIndex = 0;
            this.sourcePic.TabStop = false;
            // 
            // pictureBox2
            // 
            this.processedPic.Location = new System.Drawing.Point(12, 108);
            this.processedPic.Name = "processedPic";
            this.processedPic.Size = new System.Drawing.Size(207, 89);
            this.processedPic.TabIndex = 1;
            this.processedPic.TabStop = false;
            // 
            // textBox1
            // 
            this.recognizedText.Location = new System.Drawing.Point(25, 227);
            this.recognizedText.Name = "recognizedText";
            this.recognizedText.Size = new System.Drawing.Size(322, 20);
            this.recognizedText.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 443);
            this.Controls.Add(this.recognizedText);
            this.Controls.Add(this.processedPic);
            this.Controls.Add(this.sourcePic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.sourcePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourcePic;
        private System.Windows.Forms.PictureBox processedPic;
        private System.Windows.Forms.TextBox recognizedText;
    }
}

