// Fig. 15.43: UsingMDIForm.cs
// Demonstrating use of MDI parent and child windows.
using System;
using System.Windows.Forms;

namespace UsingMDI
{
   // Form demonstrates the use of MDI parent and child windows
   public partial class UsingMDIForm : Form
   {
      // constructor
      public UsingMDIForm()
      {
         InitializeComponent();
      } // end constructor

      // create Lavender Flowers image window
      private void lavenderToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // create new child
         ChildForm child = new ChildForm( 
            "Lavender Flowers",  "lavenderflowers" );
         child.MdiParent = this; // set parent
         child.Show(); // display child
      } // end method lavenderToolStripMenuItem_Click

      // create Purple Flowers image window
      private void purpleToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // create new child
         ChildForm child = new ChildForm( 
            "Purple Flowers", "purpleflowers" );
         child.MdiParent = this; // set parent
         child.Show(); // display child
      } // end method purpleToolStripMenuItem_Click

      // create Yellow Flowers image window
      private void yellowToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         // create new child
         ChildForm child = new ChildForm(
            "Yellow Flowers", "yellowflowers" );
         child.MdiParent = this; // set parent
         child.Show(); // display child
      } // end method yellowToolStripMenuItem_Click

      // exit application
      private void exitToolStripMenuItem_Click( 
         object sender, EventArgs e )
      {
         Application.Exit();
      } // end method exitToolStripMenuItem_Click

      // set Cascade layout
      private void cascadeToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         this.LayoutMdi( MdiLayout.Cascade );
      } // end method cascadeToolStripMenuItem_Click

      // set TileHorizontal layout
      private void tileHorizontalToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         this.LayoutMdi( MdiLayout.TileHorizontal );
      } // end method tileHorizontalToolStripMenuItem

      // set TileVertical layout
      private void tileVerticalToolStripMenuItem_Click(
         object sender, EventArgs e )
      {
         this.LayoutMdi( MdiLayout.TileVertical );
      } // end method tileVerticalToolStripMenuItem_Click
   } // end class UsingMDIForm
} // end namespace UsingMDI

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
