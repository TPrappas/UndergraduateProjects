using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace question12
{   
    public class Lecture
    {
        public string Day { get; set; }
        public string Time { get; set; }

        [XmlAttribute]
        public string Classroom { get; set; }
    }
}
