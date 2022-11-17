using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace question12
{
    public class Schedule
    {
        [XmlElement("Lesson")]
        public List<Lesson> LessonList { get; set; } = new List<Lesson>(); 
    }
}
