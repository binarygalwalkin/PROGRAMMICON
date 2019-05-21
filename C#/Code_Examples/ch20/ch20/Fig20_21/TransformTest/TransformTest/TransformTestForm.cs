// Fig. 20.21: TransformTestForm.cs
// Applying an XSLT style sheet to an XML Document.
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Xsl; // contains class XslCompiledTransform

namespace TransformTest
{
   public partial class TransformTestForm : Form
   {
      public TransformTestForm()
      {
         InitializeComponent();
      } // end constructor

      // applies the transformation
      private XslCompiledTransform transformer;

      // initialize variables
      private void TransformTestForm_Load( object sender, EventArgs e )
      {
         transformer = new XslCompiledTransform(); // create transformer

         // load and compile the style sheet
         transformer.Load( "sports.xsl" );
      } // end method TransformTestForm_Load

      // transform data on transformButton_Click event
      private void transformButton_Click( object sender, EventArgs e )
      {
         // perform the transformation and store the result in new file
         transformer.Transform( "sports.xml", "sports.html" );

         // read and display the XHTML document's text in a TextBox
         consoleTextBox.Text = File.ReadAllText( "sports.html" );
      } // end method transformButton_Click
   } // end class TransformTestForm
} // end namespace TransformTest

/**************************************************************************
 * (C) Copyright 1992-2009 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************/
