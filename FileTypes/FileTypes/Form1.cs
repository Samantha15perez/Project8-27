using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace FileTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string type;


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = @"C:\";
            openFileDialog2.Title = "Please Select A File";
            openFileDialog2.DefaultExt = "zip";
            openFileDialog2.Filter = "All files (*.*)|*.*|Audio|*.aif; *.cda; *.mid; *.midi; *.mp3; *.mpa; *.ogg; *.wav; *.wma; *.wpl|Zip Archive|*.7z; *.arj; *.deb; *.pkg; *.rar; *.rpm; *.tar.gz; *.z; *.zip|OS/Disc|*.bin; *.dmg; *.iso; *.toast; *.vcd|Database|*.csv; *.dat; *.db; *.dbf; *.log; *.mdb; *.sav; *.sql; *.tar; *.xml|Executable|*.apk; *.bat; *.bin; *.cgi; *.pl; *.com; *.exe; *.gadget; *.jar; *.py; *.wsf|Font|*.fnt; *.fon; *.otf; *.tff|Image|*.ai; *.bmp; *.gif; *.ico; *.jpg; *.jpeg; *.png; *.ps; *.psd; *.svg; *.tif; *.tiff; *.sai|Internet|*.asp; *.cer; *.cfm; *.cgi; *.pl; *.css; *.htm; *.html; *.js; *.jsp; *.part; *.php; *.py; *.rss; *.xhtml|Presentation|*.key; *.odp; *.pps; *.ppt; *.pptx|Programming|*.c; *.class; *.cpp; *.cs; *.h; *.java; *.sh; *.swift; *.vb|Spreadsheet|*.ods; *.xlr; *.xls; *.xlsx|SystemFiles|*.bak; *.cab; *.cfg; *.cpl; *.cur; *.dll; *.dmp; *.drv; *.icns; *.ico; *.ini; *.lnk; *.msi; *.sys; *.tmp|Video|*.3g2; *.3gp; *.avi; *.flv; *.h264; *.m4v; *.mkv; *.mov; *.mp4; *.mpg; *.mpeg; *.rm; *.swf; *.vob; *.wmv|Text|*.doc; *.docx; *.odt; *.pdf; *.rtf; *.tex; *.txt; *.wks; *.wps; *.wpd";
            openFileDialog2.CheckFileExists = true;
            openFileDialog2.CheckPathExists = true;
            openFileDialog2.Multiselect = false;
            openFileDialog2.ShowDialog();
            FileInfo info = new FileInfo(openFileDialog2.FileName);
            FileAttributes attributes = info.Attributes;
            



            if (openFileDialog2.FileName != null)
            {
                try
                {
                    string FilePath = openFileDialog2.FileName;
                    StandardFile SelectedFile = new FileTypes.StandardFile(FilePath);
                    
                    string[] DirectoryParts = FilePath.Split('\\');
                    int i = (DirectoryParts.Count()) - 1;
                    groupBox1.Text = DirectoryParts[i].ToString();
                    Icon PrevIcon = Icon.ExtractAssociatedIcon(FilePath);
                    pictureBox1.Image = PrevIcon.ToBitmap();
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    TagLib.File file = TagLib.File.Create(FilePath);

                    Regex rAudio = new Regex(".aif|.cda|.mid|.midi|.mp3|.mpa|.ogg|.wav|.wma|.wpl");
                    bool isAudio = rAudio.IsMatch(FilePath);
                    

                    Regex rCompressed = new Regex(".7z|.arj|.deb|.pkg|.rar|.rpm|.tar.gz|.z|.zip");
                    bool isCompressed = rCompressed.IsMatch(FilePath);
                    

                    // Regex rDiskMedia = new Regex(".bin|.dmg|.iso|.toast|.vcd");
                    // bool isDiskMedia = rDiskMedia.IsMatch(FilePath);

                    // Regex rDatabase = new Regex(".csv|.dat|.db|.dbf|.log|.mdb|.sav|.sql|.tar|.xml");
                    // bool isDatabase = rDatabase.IsMatch(FilePath);

                    // Regex rExecutable = new Regex("apk|.bat|.bin|.cgi|.pl|.com|.exe|.gadget|.jar|.py|.wsf");
                    // bool isExecutable = rExecutable.IsMatch(FilePath);

                    // Regex rFont = new Regex(".fnt|.fon|.otf|.otf|.ttf");
                    // bool isFont = rFont.IsMatch(FilePath);

                    Regex rImage = new Regex(".ai|.bmp|.gif|.ico|.jpeg|.jpg|.png|.ps|.psd|.svg|.tif|.tiff|.sai");
                    bool isImage = rImage.IsMatch(FilePath);
                    

                    // Regex rInternet = new Regex(".asp|.aspx|.cer|.cfm|.cgi|.pl|.css|.htm|.html|.js|.jsp|.part|.php|.py|.rss|.xhtml");
                    // bool isInternet = rInternet.IsMatch(FilePath);

                    // Regex rPresentation = new Regex(".key|.odp|.pps|.ppt|.pptx");
                    // bool isPresentation = rPresentation.IsMatch(FilePath);

                    // Regex rProgramming = new Regex(".c|.class|.cpp|.cs|.h|.java|.sh|.swift|.vb");
                    // bool isProgramming = rProgramming.IsMatch(FilePath);

                    // Regex rSpreadsheet = new Regex(".ods|.xlr|.xls|.xlsx");
                    // bool isSpreadsheet = rSpreadsheet.IsMatch(FilePath);

                    // Regex rSystemFiles = new Regex(".bak|.cab|.cfg|.cpl|.cur|.dll|.dmp|.drv|.icns|.ico|.ini|.lnk|.msi|.sys|.tmp");
                    // bool isSystemFiles = rSystemFiles.IsMatch(FilePath);

                    Regex rVideo = new Regex(".3g2|.3gp|.avi|.flv|.h264|.m4v|.mkv|.mov|.mp4|.mpg|.mpeg|.rm|.swf|.vob|.wmv");
                    bool isVideo = rVideo.IsMatch(FilePath);
                    

                    Regex rText = new Regex(".doc|.docx|.odt|.pdf|.rtf|.tex|.wks|.wps|.wpd");
                    bool isText = rText.IsMatch(FilePath);
                    


                    if (openFileDialog2.FileName != "")
                    {
                        panelFile.Visible = true;
                        labelFileName.Text = SelectedFile._name;

                        string size = SelectedFile.Size.ToString();
                        
                        if (int.Parse(size)  > 1000000)
                        {
                            size = (int.Parse(size) / 1000000).ToString() + " Megabytes";
                        }
                        else if (int.Parse(size) > 1000)
                        {
                            size = (int.Parse(size) / 1000).ToString() + " Kilobytes";
                        }
                        else
                        {
                            size = size + "Bytes";
                        }

                        labelRO.Text = SelectedFile.ReadOnly.ToString();
                      
                        
                        labelDateCreated.Text = info.CreationTime.ToString();
                        labelFileSize.Text = size;


                            
                    }

                    if (isAudio == true)
                    {
                        panelAudio.Visible = true;
                        panelImage.Visible = false;
                        panelVideo.Visible = false;
                        labelMusicArtist.Text = file.Tag.FirstAlbumArtist;
                        labelAlbumName.Text = file.Tag.Album;
                        labelYear.Text = file.Tag.Year.ToString();
                        double duration = (file.Properties.Duration.TotalSeconds / 60.6);
                        labelMusicLength.Text = duration.ToString();
                        labelBitrate.Text = (file.Properties.AudioBitrate.ToString()) + "bps";
                        labelFileType.Text = "Audio ( " + SelectedFile.Extension + " )";


                    }

                    else if (isCompressed == true)
                    {
                        //panelCompressed.Visible = true;
                    }

                    //else if (isDiskMedia == true)
                    //{
                    //    //panelDisk.Visible = true;
                    //}

                    //else if (isDatabase == true)
                    //{
                    //    //panelDatabase.Visible = true;
                    //}

                    //else if (isExecutable == true)
                    //{
                    //    // panelExecutable.Visible = true;
                    //}

                    else if (isImage == true)
                    {
                        labelFileType.Text = "Graphic ( " + SelectedFile.Extension + " )";
                        panelImage.Visible = true;
                        panelAudio.Visible = false;
                        labelImageLength.Text = file.Properties.PhotoHeight.ToString();
                        labelImageWidth.Text = file.Properties.PhotoWidth.ToString();
                        labelWRES.Text = "";
                        labelLRES.Text = "";


                    }

                    //else if (isInternet == true)
                    //{
                    //    // panelInternet.Visible = true;
                    //}

                    //else if (isPresentation == true)
                    //{
                    //    //panelPresentation.Visible = true;
                    //}

                    //else if (isProgramming == true)
                    //{
                    //    // panelProgramming.Visible = true;
                    //}

                    //else if (isSpreadsheet == true)
                    //{
                    //    //panelSpreadsheet.Visible = true;
                    //}

                    //else if (isSystemFiles == true)
                    //{
                    //    // panelSystemFiles.Visible = true;
                    //}

                    else if (isVideo == true)
                    {
                        panelVideo.Visible = true;
                        labelFileType.Text = "Video ( " + SelectedFile.Extension + " )";
                    }

                    else if (isText == true)
                    {
                        //panelText.Visible = true;
                    }

                    else
                    {
                        panelAudio.Visible = false;
                        panelImage.Visible = false;
                        panelVideo.Visible = false;
                    }

                    if (FilePath == null)
                    {
                        MessageBox.Show("!");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelMusicArtist_Click(object sender, EventArgs e)
        {

        }

        private void labelMusicLength_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
