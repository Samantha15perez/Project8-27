﻿namespace FileTypes
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMusicArtist = new System.Windows.Forms.Label();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMusicLength = new System.Windows.Forms.Label();
            this.panelAudio = new System.Windows.Forms.Panel();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAudio.SuspendLayout();
            this.panelVideo.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelImage);
            this.groupBox1.Controls.Add(this.panelVideo);
            this.groupBox1.Controls.Add(this.panelAudio);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select A File";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Read Only:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hidden:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "File Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Artist:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Album:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Year:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Length:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Bitrate:";
            this.label11.Click += new System.EventHandler(this.label10_Click);
            // 
            // labelMusicArtist
            // 
            this.labelMusicArtist.AutoSize = true;
            this.labelMusicArtist.Location = new System.Drawing.Point(44, 1);
            this.labelMusicArtist.Name = "labelMusicArtist";
            this.labelMusicArtist.Size = new System.Drawing.Size(13, 13);
            this.labelMusicArtist.TabIndex = 3;
            this.labelMusicArtist.Text = "--";
            this.labelMusicArtist.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(44, 14);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(13, 13);
            this.labelAlbumName.TabIndex = 3;
            this.labelAlbumName.Text = "--";
            this.labelAlbumName.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(44, 27);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(13, 13);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "--";
            this.labelYear.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // labelMusicLength
            // 
            this.labelMusicLength.AutoSize = true;
            this.labelMusicLength.Location = new System.Drawing.Point(44, 40);
            this.labelMusicLength.Name = "labelMusicLength";
            this.labelMusicLength.Size = new System.Drawing.Size(13, 13);
            this.labelMusicLength.TabIndex = 3;
            this.labelMusicLength.Text = "--";
            this.labelMusicLength.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // panelAudio
            // 
            this.panelAudio.Controls.Add(this.label6);
            this.panelAudio.Controls.Add(this.labelMusicLength);
            this.panelAudio.Controls.Add(this.label9);
            this.panelAudio.Controls.Add(this.labelYear);
            this.panelAudio.Controls.Add(this.label8);
            this.panelAudio.Controls.Add(this.labelAlbumName);
            this.panelAudio.Controls.Add(this.labelMusicArtist);
            this.panelAudio.Controls.Add(this.label7);
            this.panelAudio.Location = new System.Drawing.Point(77, 19);
            this.panelAudio.Name = "panelAudio";
            this.panelAudio.Size = new System.Drawing.Size(116, 59);
            this.panelAudio.TabIndex = 4;
            this.panelAudio.Visible = false;
            this.panelAudio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAudio_Paint);
            // 
            // panelVideo
            // 
            this.panelVideo.Controls.Add(this.label10);
            this.panelVideo.Controls.Add(this.label12);
            this.panelVideo.Controls.Add(this.label13);
            this.panelVideo.Controls.Add(this.label14);
            this.panelVideo.Controls.Add(this.label15);
            this.panelVideo.Controls.Add(this.label16);
            this.panelVideo.Controls.Add(this.label17);
            this.panelVideo.Controls.Add(this.label18);
            this.panelVideo.Location = new System.Drawing.Point(77, 84);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(129, 58);
            this.panelVideo.TabIndex = 4;
            this.panelVideo.Visible = false;
            this.panelVideo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAudio_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Length:";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "--";
            this.label12.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "FPS:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "--";
            this.label14.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Height:";
            this.label15.Click += new System.EventHandler(this.label1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "--";
            this.label16.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "--";
            this.label17.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Width:";
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.label19);
            this.panelImage.Controls.Add(this.label20);
            this.panelImage.Controls.Add(this.label21);
            this.panelImage.Controls.Add(this.label22);
            this.panelImage.Controls.Add(this.label23);
            this.panelImage.Controls.Add(this.label24);
            this.panelImage.Controls.Add(this.label25);
            this.panelImage.Controls.Add(this.label26);
            this.panelImage.Location = new System.Drawing.Point(77, 148);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(129, 58);
            this.panelImage.TabIndex = 4;
            this.panelImage.Visible = false;
            this.panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAudio_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Length:";
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(44, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "--";
            this.label20.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 40);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "W Res:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(44, 27);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "--";
            this.label22.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "L Res:";
            this.label23.Click += new System.EventHandler(this.label1_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(44, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 3;
            this.label24.Text = "--";
            this.label24.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(44, 1);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 13);
            this.label25.TabIndex = 3;
            this.label25.Text = "--";
            this.label25.Click += new System.EventHandler(this.labelMusicArtist_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Width:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 294);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAudio.ResumeLayout(false);
            this.panelAudio.PerformLayout();
            this.panelVideo.ResumeLayout(false);
            this.panelVideo.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMusicArtist;
        private System.Windows.Forms.Label labelMusicLength;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelAlbumName;
        private System.Windows.Forms.Panel panelAudio;
        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}

