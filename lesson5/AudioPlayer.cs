using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson5
{
    class AudioPlayer
    {
        private bool Locked;
        private bool IsPlaying;
        private Song PlayingSong;

        private int _volume;
        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value < 0) _volume = 0;
                else if (value > 100) _volume = 100;
                else _volume = value;
            }
        }

        public void Add(Song song)
        {
            List<Song> songs = this.songs.ToList();
            songs.Add(song);
            this.songs = songs.ToArray();
        }

        public void Stop()
        {
            if (Locked)
                IsPlaying = false;

        }

        public void Add(string author)
        {
            List<Song> songs = this.songs.ToList();
            songs.AddRange(this.songs.Where(w => w.Author == author));
            this.songs = songs.ToArray();
        }

        public void Add(string[] Playlist)
        {
            var songs = this.songs.Where(w=>Playlist.Contains(w.Name));
            this.songs = songs.ToArray();
        }

        public void Add(string[] Playlist)
        {
            var songs = this.songs.Where(w => Playlist.Contains(w.Name));
            this.songs = songs.ToArray();
        }


        public void Play()
        {
            if (!Locked)
                IsPlaying = true;
            if (PlayingSong == null)
                PlayingSong = songs.FirstOrDefault();
            for (var i = 0; i < 10; i++)
                Console.WriteLine(PlayingSong.Lyrics);
         }
        public Song[] songs;

        public void VolumeUp()
        {
            //Volume++;
            Volume = Volume + 1;
        }

        public void Lock()
        {
            Locked = true;
        }

        public void UnLock()
        {
            Locked = false;
        }

        public void VolumeDown()
        {
            //Volume--;
            Volume = Volume - 1;
        }

        public void VolumeChange(int step)
        {
            //Volume--;
            Volume += step;
        }

    }
}
