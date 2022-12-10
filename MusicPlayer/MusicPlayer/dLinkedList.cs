using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlayer
{
    public class dLinkedList
    {
        internal dNode head;
        internal dNode tail;
        private int len = 0;

        public dLinkedList()
        {
            this.head = null;
            this.tail = null;
        }
        internal void addNode(Song newSong)
        {
            dNode newNode = new dNode(newSong);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.prev = tail;
                tail.next = newNode;

            }
            tail = newNode;
            len++;
        }

        public int getLen()
        {
            return len;

        }

    }
}