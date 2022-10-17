using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    public class RadioData
    {
        private string artistname;
        private string songname;
        private int minutes;
        private int seconds;

        public RadioData(string artistname, string songname, int minutes, int seconds)
        {
            this.Artistname = artistname;
            this.Songname = songname;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
        public string Artistname
        {
            get { return this.artistname; }
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols");
                }
                this.artistname = value;
            }
        }
        public string Songname
        {
            get { return this.songname; }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols");
                }
                this.songname = value;
            }
        }
        public int Minutes
        {
            get { return this.minutes; }
            set
            {
                if (value < 0 || value > 14)
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14");
                }
                this.minutes = value;
            }
        }
        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                if (value < 0 || value > 59 )
                {
                    throw new ArgumentException("Song seconds should be between 0 and 59");
                }
                this.seconds = value;
            }
        }

    }
}
