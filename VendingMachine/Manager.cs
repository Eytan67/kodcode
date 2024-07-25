using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace VendingMachine
{
    public static class Manager
    {
        private static string currentDir = Directory.GetCurrentDirectory();
        private static string correctedPath = currentDir.Replace("\\bin\\Debug", "");
        private static string filePath = Path.Combine(correctedPath, "Drinks.xml");
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
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(filePath);
            }
            return null ;

        }

        public static DataTable GetData()
        {
            XmlDocument xmlDoc = GetXmlDocument();

            if (xmlDoc != null )
            {
                //create and edit DataTable columns 
                DataTable dt = new DataTable();
                XmlNode exmpleNode = xmlDoc.SelectSingleNode("/Drinks/Drink");
                if(exmpleNode != null)
                {
                    foreach (XmlNode node in exmpleNode)
                    {
                        dt.Columns.Add(node.Name);
                    }
                }
                //Loads the information into the DataTable
                XmlNodeList drinksList = xmlDoc.SelectNodes("/Drinks/Drink");
                if (drinksList != null )
                {
                    foreach (XmlNode drink in drinksList)
                    {
                        DataRow row = dt.NewRow();
                        foreach (XmlNode childe in drink)
                        {
                            row[childe.Name] = childe.InnerText;
                        }
                        dt.Rows.Add(row);
                    }
                    return dt;
                }
            }
            return null ;

        }
        public static void AddNewDrink(Drink drink)
        {
            XmlDocument xmlDoc = GetXmlDocument();

            if (xmlDoc != null)
            {
                try 
                {
                    XmlNode existingDrink = xmlDoc.SelectSingleNode($"/Drinks/Drink[Name='{drink.Name}']");
                    if (existingDrink != null)
                    {
                        MessageBox.Show("Drink with this name already exists.");
                        return;
                    }

                    XmlElement newDrink = xmlDoc.CreateElement("Drink");

                    XmlElement name = xmlDoc.CreateElement("Name");
                    name.InnerText = drink.Name;
                    newDrink.AppendChild(name);

                    XmlElement suger = xmlDoc.CreateElement("Suger");
                    suger.InnerText = drink.Suger.ToString();
                    newDrink.AppendChild(suger);

                    XmlElement milk = xmlDoc.CreateElement("Milk");
                    milk.InnerText = drink.Milk.ToString();
                    newDrink.AppendChild(milk);

                    XmlElement cocoa = xmlDoc.CreateElement("Cocoa");
                    cocoa.InnerText = drink.Cocoa.ToString();
                    newDrink.AppendChild (cocoa);

                    XmlElement coffee = xmlDoc.CreateElement("Coffee");
                    coffee.InnerText = drink.Coffee.ToString();
                    newDrink.AppendChild(coffee);

                    XmlElement price = xmlDoc.CreateElement("Price");
                    price.InnerText = drink.Price.ToString();
                    newDrink.AppendChild(price);

                    xmlDoc.DocumentElement.AppendChild(newDrink);

                    xmlDoc.Save(filePath);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void UpdateDrink(string name, Drink drink)
        {
            XmlDocument xmlDoc = GetXmlDocument();

            if (xmlDoc != null)
            {
                try
                {
                    XmlNode drinksNode = xmlDoc.SelectSingleNode($"/Drinks/Drink[Name='{name}']");
                            drinksNode.SelectSingleNode("Name").InnerText = drink.Name;
                            drinksNode.SelectSingleNode("Suger").InnerText = drink.Suger.ToString();
                            drinksNode.SelectSingleNode("Milk").InnerText = drink.Milk.ToString();
                            drinksNode.SelectSingleNode("Cocoa").InnerText = drink.Cocoa.ToString();
                            drinksNode.SelectSingleNode("Coffee").InnerText = drink.Coffee.ToString();
                            drinksNode.SelectSingleNode("Price").InnerText = drink.Price.ToString();
                    xmlDoc.Save(filePath);
                }
                catch( Exception ex ) 
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }

        public static void Delete(string name)
        {
            XmlDocument xmlDoc = GetXmlDocument();

            if (xmlDoc != null)
            {
                try
                {
                    XmlNode drinksNode = xmlDoc.SelectSingleNode($"/Drinks/Drink[Name='{name}']");
                    drinksNode.ParentNode.RemoveChild(drinksNode);
                    xmlDoc.Save(filePath    );
                }
                catch(Exception ex )
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}

