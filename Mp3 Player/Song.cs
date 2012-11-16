using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TagLib;

namespace Mp3_Player
{
    public class Song
    {
        private string pathname;
        private string filename;

        public Song(string path)
        {
            pathname = path;
        }

        public string GetPathname()
        {
            return pathname;
        }

        public string GetFilename()
        {
            filename = pathname.Split('\\').Last();
            filename = filename.Substring(0, filename.Length - 4);

            return filename;
        }

        public string GetMetadata()
        {
            TagLib.File tagFile = TagLib.File.Create(pathname);

            string author = tagFile.Tag.Performers.ElementAtOrDefault(0);
            string title = tagFile.Tag.Title;

            if (title == "")
                return GetFilename();

            string link = " - ";
            if (author == "")
                link = "";

            string tag_filename = author + link + title;

            if (tag_filename != " - ")
                filename = tag_filename;

            return author + link + title;
        }
    }
}
