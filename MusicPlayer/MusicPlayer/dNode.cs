using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
    public class dNode
    {
        internal Song data;
        internal dNode next;
        internal dNode prev;
        public dNode(Song newSong)
        {
            this.data = newSong;
            this.next = null;
           this. prev = null;
        }
    }
}