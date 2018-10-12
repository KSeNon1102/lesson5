using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class PlayList
    {
        private Song[] songs;

        public Song[] GetSongs { get { return songs; } }
        public PlayList()
        {

        }
        public PlayList(Song[] songs)
        {
            this.songs = songs;
        }

        public Song[] Add(Song song)
        {
            (songs.ToList()).Add(song);
            return GetSongs;
        }
    }
}
