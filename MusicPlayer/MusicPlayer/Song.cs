using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
    public class Song
    {
        private string url;
        private string title;
        public Song(string url, string title)
        {
            this.url = url;
            this.title = title;
        }

        public string getUrl()
        {
            return url;
        }
        public string getTitle()
        {
            return title;
        }
    }
}