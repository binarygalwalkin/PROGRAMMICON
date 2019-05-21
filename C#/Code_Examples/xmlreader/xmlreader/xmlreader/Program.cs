using System;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.Text;

namespace xmlreader
{
    class Program
    {
        static void Main(string[] args)
        {// Create an XML reader for this file.
            using (XmlReader reader = XmlReader.Create("test.xml"))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (reader.Name)
                        {
                            case "test":
                                // Detect this element.
                                Console.WriteLine("Start <test> element.");
                                break;
                            case "article":
                                // Detect this article element.
                                Console.WriteLine("Start <article> element.");
                                // Search for the attribute name on this current node.
                                string attribute = reader["name"];
                                if (attribute != null)
                                {
                                    Console.WriteLine(" Has attribute name: " + attribute);
                                }
                                // Next read will contain text.
                                if (reader.Read())
                                {
                                    Console.WriteLine(" Text node: " + reader.Value.Trim());
                                }
                                break;
                        }//end switch
                    }//endwhile
                }//end using

            }//end main
        }
    }
}

