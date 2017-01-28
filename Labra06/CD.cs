using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Song
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public override string ToString()
        {
            return Name + " " + Duration;
        }
    }
    class CD
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        private List<Song> songs;
        public List<Song> Tracklist
        {
            get { return songs; }
        }
        public CD()
        {
            songs = new List<Song>();
        }
        public void AddTrack(Song sng)
        {
            songs.Add(sng);
        }
        public Song FindSong(int index)
        {
            if(index < songs.Count)
            {
                return songs.ElementAt(index);
            }
            else
            {
                return null;
            }
        }
    }
}
