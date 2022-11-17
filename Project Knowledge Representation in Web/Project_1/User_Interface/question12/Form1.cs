using System.Xml.Serialization;

namespace question12
{
    public partial class Form1 : Form
    {
        private XmlSerializer mXs;
        private Schedule mSchedule = new();
        private Lesson mLessons = new();
        
        // Path of XML file
        private const string mPath = @"C:/CEID_projects/Representation/еяцасиа 1/question12.xml";

        public Form1()
        {
            InitializeComponent();

            mXs = new XmlSerializer(typeof(Schedule));

            // Gets days of week for comboBox
            var daysOfWeek = Enum.GetValues(typeof(DayOfWeek));

            var daysOptions = new List<string>();
            var existingDaysOptions = new List<string>();
            foreach (var day in daysOfWeek)
                daysOptions.Add(day.ToString());

            lessonSelectDayComboBox.DataSource = daysOptions;
            lessonSelectDayComboBox.SelectedIndex = 1;

            existingDaysOptions.Add("All");
            existingDaysOptions.AddRange(daysOptions);

            lessonDayComboBox.DataSource = existingDaysOptions;
        }

        // When we click Add button
        private void lessonAdd_Click(object sender, EventArgs e)
        {
         
            FileStream fs = new FileStream(mPath, FileMode.Create, FileAccess.Write);
            
            var mLectures = new List<Lecture>();

            // Create new lecture  
            var lecture = new Lecture()
            {
                Day = lessonSelectDayComboBox.SelectedItem.ToString(),
                Time = lessonTimeTextBox.Text,
                Classroom = lessonClassroomTextBox.Text
            };

            // Adds lecture to mLectures list
            mLectures.Add(lecture);

            // Create new lesson
            var lesson = new Lesson()
            {
                Title = lessonTitleTextBox.Text,
                Professor = lessonProfessorTextBox.Text,
                LectureList = mLectures
            };

            // Adds lesson to LessonList of Schedule class
            mSchedule.LessonList.Add(lesson);

            // Create the elements at XML
            mXs.Serialize(fs, mSchedule);
            fs.Close();
        }

        // When we click Read button
        private void lessonRead_Click(object sender, EventArgs e)
        {
     
            FileStream fs = new FileStream(mPath, FileMode.Open, FileAccess.Read);
            mSchedule = (Schedule)mXs.Deserialize(fs);
            var data = new List<object>();

            // If comboBox equals to All
            if(lessonDayComboBox.SelectedItem.ToString() == "All")
            {
                // Gets every object of XML file
                mSchedule?.LessonList.ForEach(x =>
                {
                    data.AddRange(x.LectureList.Select(y => new
                    {
                        Title = x.Title,
                        Professor = x.Professor,
                        Classroom = y.Classroom,
                        Day = y.Day,
                        Time = y.Time
                    }));
                });
            }
            // Else comboBox equals to a day of the week
            else
            {
                // Gets every object of XML with day equal to comboBox day
                mSchedule?.LessonList.ForEach(x =>
                {
                    data.AddRange(x.LectureList.Where(z => z.Day == lessonDayComboBox.SelectedItem.ToString()).Select(y => new
                    {
                        Title = x.Title,
                        Professor = x.Professor,
                        Classroom = y.Classroom,
                        Day = y.Day,
                        Time = y.Time
                    }));
                });
            }

            // Show object in data grid
            lessonDataGrid.DataSource = data;
            fs.Close();
        }

    }
}