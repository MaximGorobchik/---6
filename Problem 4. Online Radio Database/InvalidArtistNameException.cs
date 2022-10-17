using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    public class InvalidArtistNameException : InvalidSongException
    {
        public override string Message => "Artist name should be between 3 and 20 symbols";
    }
}
