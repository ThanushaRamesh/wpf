namespace WPF_ManageStudents
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string matNumber { get; set; }

        public string gender { get; set; } //m= male, f= female

        [System.Xml.Serialization.XmlIgnore]
        public string name { get { return $"{ firstName} { lastName}"; } }
        public string MyProperty { get; set; }

    }
}