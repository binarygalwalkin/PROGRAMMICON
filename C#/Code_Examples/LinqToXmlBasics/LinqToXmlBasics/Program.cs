using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace LinqToXmlBasics
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("***** Fun with LINQ to XML *****\n");
      CreateFunctionalXmlElement();
      Console.WriteLine();
      CreateFunctionalXmlDoc();
      Console.WriteLine();
      CreateXmlDocFromArray();
      Console.WriteLine();
      LoadExistingXml();
      Console.ReadLine();
    }

    #region Create XML docs
    static void CreateFunctionalXmlElement()
    {
      // A 'functional' approach to build an 
      // XML element in memory.
      XElement inventory =
        new XElement("Inventory",
          new XElement("Car", new XAttribute("ID", "1"),
            new XElement("Color", "Green"),
            new XElement("Make", "BMW"),
            new XElement("PetName", "Stan")
          )
        );
      // Call ToString() on our XElement. 
      Console.WriteLine(inventory);
    }

    static void CreateFunctionalXmlDoc()
    {
      XDocument inventoryDoc =
        new XDocument(
          new XDeclaration("1.0", "utf-8", "yes"),
          new XComment("Current Inventory of AutoLot"),
            new XElement("Inventory",
              new XElement("Car", new XAttribute("ID", "1"),
                new XElement("Color", "Green"),
                new XElement("Make", "BMW"),
                new XElement("PetName", "Stan")
              ),
              new XElement("Car", new XAttribute("ID", "2"),
                new XElement("Color", "Pink"),
                new XElement("Make", "Yugo"),
                new XElement("PetName", "Melvin")
              )
            )
          );
      // Display the document and save to disk.
      Console.WriteLine(inventoryDoc);
      inventoryDoc.Save("SimpleInventory.xml");
    }
    #endregion

    #region Build doc from LINQ query
    static void CreateXmlDocFromArray()
    {
      // Create an anonymous array of types.
      var data = new[] {
        new { PetName = "Melvin", ID = 10 },
        new { PetName = "Pat", ID = 11 },
        new { PetName = "Danny", ID = 12 },
        new { PetName = "Clunker", ID = 13 }
      };

      // Now enumerate over the array to build
      // an XElement.
      XElement vehicles =
        new XElement("Inventory",
          from c in data
          select new XElement("Car",
      new XAttribute("ID", c.ID),
      new XElement("PetName", c.PetName)
          )
        );
      Console.WriteLine(vehicles);
    }
    #endregion

    #region Load XML
    static void LoadExistingXml()
    {
      // Build an XElement from string.
      string myElement =
        @"<Car ID ='3'>
            <Color>Yellow</Color>
            <Make>Yugo</Make>    
          </Car>";
      XElement newElement = XElement.Parse(myElement);
      Console.WriteLine(newElement);
      Console.WriteLine();

      // Load the SimpleInventory.xml file.
      XDocument myDoc = XDocument.Load("SimpleInventory.xml");
      Console.WriteLine(myDoc);
    }
    #endregion
  }
}
