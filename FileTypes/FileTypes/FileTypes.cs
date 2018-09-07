using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileTypes
{


    class StandardFile
    {
        //fields
        private string _filepath;
        private FileInfo _fileObjInfo;
        private int _size;
        private string _location;
        private bool _readOnly;
        private bool _hidden;
        private string _extension;
        private string[] _ext;
        public string _name;
        private string[] _namesplit;

        //constructor
        public StandardFile()
        {
            _filepath = "";
            _name = "";
            _size = 0;
            _location = "";
            _readOnly = false;
            _hidden = false;
            _extension = "";
        }

        //filepath property
        public StandardFile(string FilePath)
        {
            _filepath = FilePath;
            _fileObjInfo = new FileInfo(FilePath);
            _size = (int)_fileObjInfo.Length;
            _location = FilePath;
            _ext = FilePath.Split('.');
            _extension = _ext[1];
            _namesplit = FilePath.Split('\\');
            _name = _namesplit[(_namesplit.Length - 1)].Replace(("." +_extension), "");
        }

        //size property
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        //location property
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        //readonly property
        public bool ReadOnly
        {
            get { return (_fileObjInfo != null) ? _fileObjInfo.Attributes.HasFlag(FileAttributes.ReadOnly) : false; }

        }

        //hidden property
        public bool Hidden
        {
            get { return _hidden; }
            set { _hidden = value; }
        }

        //extension property
        public string Extension
        {
            get { return _extension; }
            set { _extension = value; }
        }
    }

    class Audio : StandardFile
    {
       
        //field
        private string _artist;
        private string _album;
        private int _year;
        private int _length;
        private int _bitrate;

        //constructor
        public Audio()
        {
            _artist = "";
            _album = "";
            _year = 0;
            _length = 0;
            _bitrate = 0;
        }

        //artist property
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        //album property
        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }

        //artist property
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        //artist property
        public int length
        {
            get { return _length; }
            set { _length = value; }
        }

        //artist property
        public int bitrate
        {
            get { return _bitrate; }
            set { _bitrate = value; }
        }

        /*
        .aif - AIF audio file
        .cda - CD audio track file
        .mid or .midi - MIDI audio file.
        .mp3 - MP3 audio file
        .mpa - MPEG-2 audio file
        .ogg - Ogg Vorbis audio file
        .wav - WAV file
        .wma - WMA audio file
        .wpl - Windows Media Player playlist 
        */
    }

    class Compressed : StandardFile
    {
        //compressed files are pretty basic.

        /*
        .7z - 7-Zip compressed file
        .arj - ARJ compressed file
        .deb - Debian software package file
        .pkg - Package file
        .rar - RAR file
        .rpm - Red Hat Package Manager
        .tar.gz - Tarball compressed file
        .z - Z compressed file
        .zip - Zip compressed file
        */
    }

    class Disc : StandardFile
    {
        //disc files are pretty basic.

        /*
        .bin - Binary disc image
        .dmg - macOS X disk image
        .iso - ISO disc image
        .toast - Toast disc image
        .vcd - Virtual CD
        */
    }

    class Database : StandardFile
    {
        //field
        private string _associatedProgram;

        //constructor
        public Database()
        {
            _associatedProgram = "";
        }

        //database property
        public string AssociatedProgram
        {
            get { return _associatedProgram; }
            set { _associatedProgram = value; }
        }

        /*
        .csv - Comma separated value file
        .dat - Data file
        .db or .dbf - Database file
        .log - Log file
        .mdb - Microsoft Access database file
        .sav - Save file (e.g., game save file)
        .sql - SQL database file
        .tar - Linux / Unix tarball file archive
        .xml - XML file
        */
    }

    class Executable : StandardFile
    {
        //field
        private string _operatingSystem;

        //constructor
        public Executable()
        {
            _operatingSystem = "";
        }

        //operatingsystem property
        public string OperatingSystem
        {
            get { return _operatingSystem; }
            set { _operatingSystem = value; }
        }
        /*
        .apk - Android package file
        .bat - Batch file
        .bin - Binary file
        .cgi or .pl - Perl script file
        .com - MS-DOS command file
        .exe - Executable file
        .gadget - Windows gadget
        .jar - Java Archive file
        .py - Python file
        .wsf - Windows Script StandardFile
        */
    }

    class Font : StandardFile
    {
        //field
        private string _language;

        //constructor
        public Font()
        {
            _language = "";
        }

        //operatingsystem property
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        /*
        .fnt - Windows font file
        .fon - Generic font file
        .otf - Open type font file
        .ttf - TrueType font file
        */
    }

    class Image : StandardFile
    {
        //field
        private int _width;
        private int _height;
        private int _horizontalResolution;
        private int _verticalResolution;

        //constructor
        public Image()
        {
            _width = 0;
            _height = 0;
            _horizontalResolution = 0;
            _verticalResolution = 0;
        }

        //width property
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        //height property
        public int Language
        {
            get { return _height; }
            set { _height = value; }
        }

        //horizontalResolution property
        public int HorizontalResolution
        {
            get { return _horizontalResolution; }
            set { _horizontalResolution = value; }
        }

        //verticalResolution property
        public int verticalResolution
        {
            get { return _verticalResolution; }
            set { _verticalResolution = value; }
        }


        /*
        .ai - Adobe Illustrator file
        .bmp - Bitmap image
        .gif - GIF image
        .ico - Icon file
        .jpeg or .jpg - JPEG image
        .png - PNG image
        .ps - PostScript file
        .psd - PSD image
        .svg - Scalable Vector Graphics file
        .tif or .tiff - TIFF image
        */
    }

    class Internet : StandardFile
    {
        //i dont know how to go about these just yet

        /*
        .asp and .aspx - Active Server Page file
        .cer - Internet security certificate
        .cfm - ColdFusion Markup file
        .cgi or .pl - Perl script file
        .css - Cascading Style Sheet file
        .htm and .html - HTML file
        .js - JavaScript file
        .jsp - Java Server Page file
        .part - Partially downloaded file
        .php - PHP file
        .py - Python file
        .rss - RSS file
        .xhtml - XHTML file
        */
    }

    class Presentation : StandardFile
    {
        //i dont know how to go about these just yet

        /*
        .key - Keynote presentation
        .odp - OpenOffice Impress presentation file
        .pps - PowerPoint slide show
        .ppt - PowerPoint presentation
        .pptx - PowerPoint Open XML presentation
        */
    }

    class Programming : StandardFile
    {
        //field
        private string _programLanguage;

        //constructor
        public Programming()
        {
            _programLanguage = "";
        }

        //programlanguage property
        public string ProgramLanguage
        {
            get { return _programLanguage; }
            set { _programLanguage = value; }
        }

        /*
        .c - C and C++ source code file
        .class - Java class file
        .cpp - C++ source code file
        .cs - Visual C# source code file
        .h - C, C++, and Objective-C header file
        .java - Java Source code file
        .sh - Bash shell script
        .swift - Swift source code file
        .vb - Visual Basic file
        */
    }

    class Spreadsheet : StandardFile
    {
        //i dont know how im going to go about this one

        /*
        .ods - OpenOffice Calc spreadsheet file
        .xlr - Microsoft Works spreadsheet file
        .xls - Microsoft Excel file
        .xlsx - Microsoft Excel Open XML spreadsheet file
        */
    }

    class SystemFiles : StandardFile
    {
        //field
        public string _fileType;

        //constructor
        public SystemFiles()
        {
            _fileType = "";
        }

        //filetype property
        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }

        /*
        .bak - Backup file
        .cab - Windows Cabinet file
        .cfg - Configuration file
        .cpl - Windows Control panel file
        .cur - Windows cursor file
        .dll - DLL file
        .dmp - Dump file
        .drv - Device driver file
        .icns - macOS X icon resource file
        .ico - Icon file
        .ini - Initialization file
        .lnk - Windows shortcut file
        .msi - Windows installer package
        .sys - Windows system file
        .tmp - Temporary file
        */
    }

    class Video : StandardFile
    {
        //field
        public int _length;
        public int _frameWidth;
        public int _frameHeight;
        public int _bitrate;
        public int _fps;

        //constructor
        public Video()
        {
            _length = 0;
            _frameWidth = 0;
            _frameHeight = 0;
            _bitrate = 0;
            _fps = 0;
        }

        //length property
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        //framewidth property
        public int Framewidth
        {
            get { return _frameWidth; }
            set { _frameWidth = value; }
        }

        //frameHeight property
        public int FrameHeight
        {
            get { return _frameHeight; }
            set { _frameHeight = value; }
        }

        //bitrate property
        public int Bitrate
        {
            get { return _bitrate; }
            set { _bitrate = value; }
        }

        //FPS property
        public int FPS
        {
            get { return _fps; }
            set { _fps = value; }
        }


        /*
        .3g2 - 3GPP2 multimedia file
        .3gp - 3GPP multimedia file
        .avi - AVI file
        .flv - Adobe Flash file
        .h264 - H.264 video file
        .m4v - Apple MP4 video file
        .mkv - Matroska Multimedia Container
        .mov - Apple QuickTime movie file
        .mp4 - MPEG4 video file
        .mpg or .mpeg - MPEG video file
        .rm - RealMedia file
        .swf - Shockwave flash file
        .vob - DVD Video Object
        .wmv - Windows Media Video file
        */
    }

    class Text : StandardFile
    {
        //i dont know how im going to go about this one

        /*
        .doc and .docx - Microsoft Word file
        .odt - OpenOffice Writer document file
        .pdf - PDF file
        .rtf - Rich Text Format
        .tex - A LaTeX document file
        .txt - Plain text file
        .wks and .wps- Microsoft Works file
        .wpd - WordPerfect document
        */
    }
}
