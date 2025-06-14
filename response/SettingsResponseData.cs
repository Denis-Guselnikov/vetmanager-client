using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lesson.response
{
    internal class SettingsResponseData
    {
        public int status { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public AuthData data { get; set; }        
    }
}
