using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TicketSystem.Helper
{
    public class TicketSystemHelper
    {
        public static XmlElement SerializeToXmlElement(object o)
        {
            XmlDocument doc = new XmlDocument();

            using (XmlWriter writer = doc.CreateNavigator().AppendChild())
            {
                new XmlSerializer(o.GetType()).Serialize(writer, o);
            }

            return doc.DocumentElement;
        }

        public static T Deserialize<T>(string input) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(input))
            {
                return (T)ser.Deserialize(sr);
            }
        }
    }
}
