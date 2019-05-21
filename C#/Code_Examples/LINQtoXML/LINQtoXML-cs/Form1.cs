using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LINQtoXML_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xmlDoc = XDocument.Load("People.xml");

            var persons = from person in xmlDoc.Descendants("Person")
            select new
            {
                Name = person.Element("Name").Value,
                City = person.Element("City").Value,
                Age = person.Element("Age").Value,
            };

            txtResults.Text = "";
            foreach (var person in persons)
            {
                txtResults.Text = txtResults.Text + "Name: " + person.Name + "\n";
                txtResults.Text = txtResults.Text + "City: " + person.City + "\n";
                txtResults.Text = txtResults.Text + "Age: " + person.Age + "\n\n";
            }

            if (txtResults.Text == "")
                txtResults.Text = "No Results.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument xmlDoc = XDocument.Load("People.xml");
            
            xmlDoc.Element("Persons").Add(new XElement("Person", new XElement("Name", txtName.Text), 
                new XElement("City", txtCity.Text), new XElement("Age", txtAge.Text)));

            xmlDoc.Save("People.xml");
        }
    }
}
