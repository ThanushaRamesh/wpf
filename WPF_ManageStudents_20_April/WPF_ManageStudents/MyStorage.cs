using System;
using System.IO;
using System.Xml.Serialization;

namespace WPF_ManageStudents
{
    internal class MyStorage
    {
        internal static void WriteXml<T>(T data, string file)
        {
            XmlSerializer sr = new XmlSerializer(typeof(T));

            FileStream stream;

            stream = new FileStream(file, FileMode.Create);

            sr.Serialize(stream, data);
            stream.Close(); // MAking sure that file is closed and doesnt cause any issue while deleting
        }
    }
}