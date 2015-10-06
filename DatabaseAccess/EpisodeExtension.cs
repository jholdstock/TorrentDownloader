using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DatabaseAccess
{
    public partial class Episode
    {
        public Episode()
        {
        }

        public Episode(JObject json)
        {
            torrentFile720 = (string)json["720"];
            torrentFile1080 = (string)json["1080"];
            torrentFileHD = (string)json["hd"];
            num = (string)json["num"];
            title = (string)json["title"];
            age = (int)json["age"];
        }

        override public string ToString()
        {
            return num + " " + title;
        }
    }
}
