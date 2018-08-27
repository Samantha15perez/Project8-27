using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filetypes_Project
{
    class File
    {
        //fields
        private int _size;
        private string _location;
        private bool _readOnly;
        private bool _hidden;

        //constructor
        public File()
        {
            _size = 0;
            _location = "";
            _readOnly = false;
            _hidden = false;
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
            get { return _readOnly; }
            set { _readOnly = value; }
        }

        //hidden property
        public bool Hidden
        {
            get { return _hidden; }
            set { _hidden = value; }
        }
    }

    class Audio : File
    {
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

    class Compressed : File
    {
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

    class Disc : File
    {
        /*
        .bin - Binary disc image
        .dmg - macOS X disk image
        .iso - ISO disc image
        .toast - Toast disc image
        .vcd - Virtual CD
        */
    }

    class Database : File
    {
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

    class Executable : File
    {
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
        .wsf - Windows Script File
        */
    }

    class Font : File
    {
        /*
        .fnt - Windows font file
        .fon - Generic font file
        .otf - Open type font file
        .ttf - TrueType font file
        */
    }

    class Image : File
    {
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

    class Internet : File
    {
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

    class Presentation : File
    {
        /*
        .key - Keynote presentation
        .odp - OpenOffice Impress presentation file
        .pps - PowerPoint slide show
        .ppt - PowerPoint presentation
        .pptx - PowerPoint Open XML presentation
        */
    }

    class Programming : File
    {
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

    class Spreadsheet : File
    {
        /*
        .ods - OpenOffice Calc spreadsheet file
        .xlr - Microsoft Works spreadsheet file
        .xls - Microsoft Excel file
        .xlsx - Microsoft Excel Open XML spreadsheet file
        */
    }

    class System : File
    {
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

    class Video : File
    {
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

    class Text : File
    {
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
