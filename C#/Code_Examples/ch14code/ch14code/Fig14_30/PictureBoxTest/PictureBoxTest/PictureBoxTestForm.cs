// Fig. 14.30: PictureBoxTestForm.cs
// Using a PictureBox to display images.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PictureBoxTest
{
   // Form to display different images when PictureBox is clicked
   public partial class PictureBoxTestForm : Form
   {
      private int imageNum = -1; // determines which image is displayed

      // default constructor
      public PictureBoxTestForm()
      {
         InitializeComponent();
      } // end constructor

      // change image whenever Next Button is clicked
      private void nextButton_Click( object sender, EventArgs e )
      {
         imageNum = ( imageNum + 1 ) % 3; // imageNum cycles from 0 to 2

         // create Image object from file, display in PicutreBox
         imagePictureBox.Image = ( Image )
            ( Properties.Resources.ResourceManager.GetObject(
            string.Format( "image{0}", imageNum ) ) );
      } // end method nextButton_Click
   } // end class PictureBoxTestForm
} // end namespace PictureBoxTest

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
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
 *************************************************************************/