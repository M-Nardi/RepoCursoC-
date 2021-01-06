using System;
using System.Collections.Generic;
using System.Text;

namespace AplicativoSocialStringBuilder.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }
        public Comment(string comment)
        {
            Text = comment;
        }


    }
}
