namespace grafikaZad2
{
    partial class Form1
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
            this.readPPM = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.readJPEG = new System.Windows.Forms.Button();
            this.saweImage100 = new System.Windows.Forms.Button();
            this.saveImage50 = new System.Windows.Forms.Button();
            this.saveImage0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // readPPM
            // 
            this.readPPM.Location = new System.Drawing.Point(253, 12);
            this.readPPM.Name = "readPPM";
            this.readPPM.Size = new System.Drawing.Size(166, 23);
            this.readPPM.TabIndex = 3;
            this.readPPM.Text = "Wczytaj PPM6";
            this.readPPM.UseVisualStyleBackColor = true;
            this.readPPM.Click += new System.EventHandler(this.readPPM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(253, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 510);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // readJPEG
            // 
            this.readJPEG.Location = new System.Drawing.Point(12, 12);
            this.readJPEG.Name = "readJPEG";
            this.readJPEG.Size = new System.Drawing.Size(133, 23);
            this.readJPEG.TabIndex = 5;
            this.readJPEG.Text = "Wczytaj JPEG";
            this.readJPEG.UseVisualStyleBackColor = true;
            this.readJPEG.Click += new System.EventHandler(this.readJPEG_Click);
            // 
            // saweImage100
            // 
            this.saweImage100.Location = new System.Drawing.Point(887, 12);
            this.saweImage100.Name = "saweImage100";
            this.saweImage100.Size = new System.Drawing.Size(144, 23);
            this.saweImage100.TabIndex = 6;
            this.saweImage100.Text = "Zapisz z kompresją 100%";
            this.saweImage100.UseVisualStyleBackColor = true;
            this.saweImage100.Click += new System.EventHandler(this.saweImage100_Click);
            // 
            // saveImage50
            // 
            this.saveImage50.Location = new System.Drawing.Point(887, 41);
            this.saveImage50.Name = "saveImage50";
            this.saveImage50.Size = new System.Drawing.Size(144, 23);
            this.saveImage50.TabIndex = 7;
            this.saveImage50.Text = "Zapisz z kompresją 50%";
            this.saveImage50.UseVisualStyleBackColor = true;
            this.saveImage50.Click += new System.EventHandler(this.saveImage50_Click);
            // 
            // saveImage0
            // 
            this.saveImage0.Location = new System.Drawing.Point(887, 70);
            this.saveImage0.Name = "saveImage0";
            this.saveImage0.Size = new System.Drawing.Size(144, 23);
            this.saveImage0.TabIndex = 8;
            this.saveImage0.Text = "Zapisz z kompresją 0%";
            this.saveImage0.UseVisualStyleBackColor = true;
            this.saveImage0.Click += new System.EventHandler(this.saveImage0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 717);
            this.Controls.Add(this.saveImage0);
            this.Controls.Add(this.saveImage50);
            this.Controls.Add(this.saweImage100);
            this.Controls.Add(this.readJPEG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.readPPM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button readPPM;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Button readJPEG;
        private System.Windows.Forms.Button saweImage100;
        private System.Windows.Forms.Button saveImage50;
        private System.Windows.Forms.Button saveImage0;
    }
}

