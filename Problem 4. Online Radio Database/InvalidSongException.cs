using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Online_Radio_Database
{
    public class InvalidSongException : Exception
    {
        private string message = "Invalid song";
        public virtual string ExceptionMessage
        {
            set
            {
                this.message = value;
            }
        }
        public override string Message => message;
    }
}
