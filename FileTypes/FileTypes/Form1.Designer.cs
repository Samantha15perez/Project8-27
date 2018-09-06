namespace FileTypes
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
            this.panelVideo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelFile = new System.Windows.Forms.Panel();
            this.labelDateCreated = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.labelFileType = new System.Windows.Forms.Label();
            this.labelRO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.labelWRES = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelLRES = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelImageWidth = new System.Windows.Forms.Label();
            this.labelImageLength = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panelAudio = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMusicLength = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAlbumName = new System.Windows.Forms.Label();
            this.labelMusicArtist = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBitrate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelVideo.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.panelAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.panelVideo);
            this.groupBox1.Controls.Add(this.panelFile);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panelImage);
            this.groupBox1.Controls.Add(this.panelAudio);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select A File";
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
            this.panelVideo.Location = new System.Drawing.Point(246, 95);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(129, 58);
            this.panelVideo.TabIndex = 4;
            this.panelVideo.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Length:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "--";
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
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Height:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "--";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "--";
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
            // panelFile
            // 
            this.panelFile.Controls.Add(this.labelDateCreated);
            this.panelFile.Controls.Add(this.labelFileName);
            this.panelFile.Controls.Add(this.label35);
            this.panelFile.Controls.Add(this.labelFileType);
            this.panelFile.Controls.Add(this.labelRO);
            this.panelFile.Controls.Add(this.label1);
            this.panelFile.Controls.Add(this.labelFileSize);
            this.panelFile.Controls.Add(this.label2);
            this.panelFile.Controls.Add(this.label3);
            this.panelFile.Controls.Add(this.label5);
            this.panelFile.Location = new System.Drawing.Point(21, 84);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(219, 64);
            this.panelFile.TabIndex = 5;
            this.panelFile.Visible = false;
            // 
            // labelDateCreated
            // 
            this.labelDateCreated.AutoSize = true;
            this.labelDateCreated.Location = new System.Drawing.Point(59, 52);
            this.labelDateCreated.Name = "labelDateCreated";
            this.labelDateCreated.Size = new System.Drawing.Size(13, 13);
            this.labelDateCreated.TabIndex = 1;
            this.labelDateCreated.Text = "--";
            this.labelDateCreated.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(59, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(13, 13);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "--";
            this.labelFileName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(-1, 52);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(38, 13);
            this.label35.TabIndex = 1;
            this.label35.Text = "Name:";
            this.label35.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFileType
            // 
            this.labelFileType.AutoSize = true;
            this.labelFileType.Location = new System.Drawing.Point(59, 39);
            this.labelFileType.Name = "labelFileType";
            this.labelFileType.Size = new System.Drawing.Size(13, 13);
            this.labelFileType.TabIndex = 1;
            this.labelFileType.Text = "--";
            this.labelFileType.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRO
            // 
            this.labelRO.AutoSize = true;
            this.labelRO.Location = new System.Drawing.Point(59, 25);
            this.labelRO.Name = "labelRO";
            this.labelRO.Size = new System.Drawing.Size(13, 13);
            this.labelRO.TabIndex = 1;
            this.labelRO.Text = "--";
            this.labelRO.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Location = new System.Drawing.Point(59, 13);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(13, 13);
            this.labelFileSize.TabIndex = 1;
            this.labelFileSize.Text = "--";
            this.labelFileSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Read Only:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "File Type:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Location = new System.Drawing.Point(272, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 59);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 1);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(43, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Length:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(44, 40);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 13);
            this.label28.TabIndex = 3;
            this.label28.Text = "--";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 40);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "W Res:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(44, 27);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(13, 13);
            this.label30.TabIndex = 3;
            this.label30.Text = "--";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 27);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(38, 13);
            this.label31.TabIndex = 1;
            this.label31.Text = "L Res:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(44, 14);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(13, 13);
            this.label32.TabIndex = 3;
            this.label32.Text = "--";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(44, 1);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(13, 13);
            this.label33.TabIndex = 3;
            this.label33.Text = "--";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 14);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(38, 13);
            this.label34.TabIndex = 2;
            this.label34.Text = "Width:";
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.label19);
            this.panelImage.Controls.Add(this.labelWRES);
            this.panelImage.Controls.Add(this.label21);
            this.panelImage.Controls.Add(this.labelLRES);
            this.panelImage.Controls.Add(this.label23);
            this.panelImage.Controls.Add(this.labelImageWidth);
            this.panelImage.Controls.Add(this.labelImageLength);
            this.panelImage.Controls.Add(this.label26);
            this.panelImage.Location = new System.Drawing.Point(17, 148);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(129, 58);
            this.panelImage.TabIndex = 4;
            this.panelImage.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Length:";
            // 
            // labelWRES
            // 
            this.labelWRES.AutoSize = true;
            this.labelWRES.Location = new System.Drawing.Point(44, 40);
            this.labelWRES.Name = "labelWRES";
            this.labelWRES.Size = new System.Drawing.Size(13, 13);
            this.labelWRES.TabIndex = 3;
            this.labelWRES.Text = "--";
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
            // labelLRES
            // 
            this.labelLRES.AutoSize = true;
            this.labelLRES.Location = new System.Drawing.Point(44, 27);
            this.labelLRES.Name = "labelLRES";
            this.labelLRES.Size = new System.Drawing.Size(13, 13);
            this.labelLRES.TabIndex = 3;
            this.labelLRES.Text = "--";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "L Res:";
            // 
            // labelImageWidth
            // 
            this.labelImageWidth.AutoSize = true;
            this.labelImageWidth.Location = new System.Drawing.Point(44, 14);
            this.labelImageWidth.Name = "labelImageWidth";
            this.labelImageWidth.Size = new System.Drawing.Size(13, 13);
            this.labelImageWidth.TabIndex = 3;
            this.labelImageWidth.Text = "--";
            this.labelImageWidth.Click += new System.EventHandler(this.label24_Click);
            // 
            // labelImageLength
            // 
            this.labelImageLength.AutoSize = true;
            this.labelImageLength.Location = new System.Drawing.Point(44, 1);
            this.labelImageLength.Name = "labelImageLength";
            this.labelImageLength.Size = new System.Drawing.Size(13, 13);
            this.labelImageLength.TabIndex = 3;
            this.labelImageLength.Text = "--";
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
            // panelAudio
            // 
            this.panelAudio.Controls.Add(this.labelBitrate);
            this.panelAudio.Controls.Add(this.label11);
            this.panelAudio.Controls.Add(this.label6);
            this.panelAudio.Controls.Add(this.labelMusicLength);
            this.panelAudio.Controls.Add(this.label9);
            this.panelAudio.Controls.Add(this.labelYear);
            this.panelAudio.Controls.Add(this.label8);
            this.panelAudio.Controls.Add(this.labelAlbumName);
            this.panelAudio.Controls.Add(this.labelMusicArtist);
            this.panelAudio.Controls.Add(this.label7);
            this.panelAudio.Location = new System.Drawing.Point(18, 148);
            this.panelAudio.Name = "panelAudio";
            this.panelAudio.Size = new System.Drawing.Size(143, 88);
            this.panelAudio.TabIndex = 4;
            this.panelAudio.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Artist:";
            // 
            // labelMusicLength
            // 
            this.labelMusicLength.AutoSize = true;
            this.labelMusicLength.Location = new System.Drawing.Point(44, 40);
            this.labelMusicLength.Name = "labelMusicLength";
            this.labelMusicLength.Size = new System.Drawing.Size(13, 13);
            this.labelMusicLength.TabIndex = 3;
            this.labelMusicLength.Text = "--";
            this.labelMusicLength.Click += new System.EventHandler(this.labelMusicLength_Click);
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
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(44, 27);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(13, 13);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Year:";
            // 
            // labelAlbumName
            // 
            this.labelAlbumName.AutoSize = true;
            this.labelAlbumName.Location = new System.Drawing.Point(44, 14);
            this.labelAlbumName.Name = "labelAlbumName";
            this.labelAlbumName.Size = new System.Drawing.Size(13, 13);
            this.labelAlbumName.TabIndex = 3;
            this.labelAlbumName.Text = "--";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Album:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelBitrate
            // 
            this.labelBitrate.AutoSize = true;
            this.labelBitrate.Location = new System.Drawing.Point(44, 53);
            this.labelBitrate.Name = "labelBitrate";
            this.labelBitrate.Size = new System.Drawing.Size(13, 13);
            this.labelBitrate.TabIndex = 5;
            this.labelBitrate.Text = "--";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Bitrate:";
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
            this.panelVideo.ResumeLayout(false);
            this.panelVideo.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.panelAudio.ResumeLayout(false);
            this.panelAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Label labelWRES;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelLRES;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelImageWidth;
        private System.Windows.Forms.Label labelImageLength;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panelFile;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.Label labelFileType;
        private System.Windows.Forms.Label labelRO;
        private System.Windows.Forms.Label labelDateCreated;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label labelBitrate;
        private System.Windows.Forms.Label label11;
    }
}

