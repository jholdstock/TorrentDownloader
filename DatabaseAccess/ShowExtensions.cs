using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace DatabaseAccess
{
    public partial class Show
    {
        public Show()
        {
        }

        public Show(JObject json)
        {
            name = (string)json["name"];
            prettyName = (string)json["pretty_name"];
            genre = (string)json["genre"];
            link = (string)json["link"];
        }

        override public string ToString()
        {
            return prettyName;
        }
    }
}
