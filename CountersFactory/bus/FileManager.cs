using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CountersFactory.bus
{
    public class FileManager
    {
        private static String xmlFilePath = @"../../../data/counters.xml";

        public static void WriteToXmlFile(List<Counter> listOfCounters)
        {
            XmlWriter xmlWriter = XmlWriter.Create(xmlFilePath);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Counter>));

            xmlSerializer.Serialize(xmlWriter, listOfCounters);

            xmlWriter.Close();
        }

        public static List<Counter> ? ReadFromXmlFile()
        {
            List<Counter>? listFromFile = new List<Counter>();

            StreamReader streamReader = new StreamReader(xmlFilePath);

            XmlSerializer xmlSerializer = new XmlSerializer (typeof(List<Counter>));

            listFromFile = (List<Counter>)xmlSerializer.Deserialize(streamReader);

            streamReader.Close();

            if (listFromFile != null )
                return listFromFile;
                   else return null;
        }
    }
}
