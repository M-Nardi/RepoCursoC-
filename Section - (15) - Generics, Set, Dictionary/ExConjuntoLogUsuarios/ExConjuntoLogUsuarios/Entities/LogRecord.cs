using System;
using System.Collections.Generic;
using System.Text;

namespace ExConjuntoLogUsuarios.Entities
{
    class LogRecord
    {
        public string Username { get; set; }
        public DateTime Moment { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }
    }
}
