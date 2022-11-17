using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace question12
{
    public class Lesson
    {
        public string Title { get; set; }
        
        [XmlElement("Lecture")]
        public List<Lecture> LectureList { get; set; } = new List<Lecture>();
        public string Professor { get; set; }
    }
}
