using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Xml;
using System.IO;


namespace WeekTest04
{


    public static class Manager
    {



        private static string currentDir = Directory.GetCurrentDirectory();
        private static string correctedPath = currentDir.Replace("\\bin\\Debug", "");
        private static string filePath = Path.Combine(correctedPath, "Queries.xml");




        public static XmlDocument GetXmlDocument()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.Load(filePath);

                    return xmlDocument;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //XmlDocument xmlDocument = new XmlDocument();
                //xmlDocument.LoadXml(filePath);

                XmlDocument xmlDoc = new XmlDocument();
                XmlNode queries = xmlDoc.CreateElement("Queries");
                xmlDoc.AppendChild(queries);
                xmlDoc.Save(filePath);
            }
            return null;

        }

        public static void AddQuery(Day newDay)
        {
            XmlDocument xmlDoc = GetXmlDocument();
            if (xmlDoc != null)
            {
                try
                {
                    XmlElement query = xmlDoc.CreateElement("Query");

                    XmlElement day = xmlDoc.CreateElement("Day");
                    day.InnerText = newDay.DayStr;
                    query.AppendChild(day);

                    XmlElement DayMonth = xmlDoc.CreateElement("DayMonth");
                    DayMonth.InnerText = newDay.DayMonth;
                    query.AppendChild(DayMonth);

                    XmlElement Month = xmlDoc.CreateElement("Month");
                    Month.InnerText = newDay.Month;
                    query.AppendChild(Month);

                    XmlElement Year = xmlDoc.CreateElement("Year");
                    Year.InnerText = newDay.Year;
                    query.AppendChild(Year);

                    XmlElement Result = xmlDoc.CreateElement("Result");
                    Result.InnerText = newDay.Result;
                    query.AppendChild(Result);

                    xmlDoc.DocumentElement.AppendChild(query);

                    xmlDoc.Save(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
 

