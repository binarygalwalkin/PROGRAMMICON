// Fig. 15.36: UsingTabsForm.cs
// Using TabControl to display various font settings.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UsingTabs
{
   // Form uses Tabs and RadioButtons to display various font settings
   public partial class UsingTabsForm : Form
   {
      // constructor
      public UsingTabsForm()
      {
         InitializeComponent();
      } // end constructor

      // event handler for Black RadioButton
      private void blackRadioButton_CheckedChanged(
         object sender, EventArgs e )
      {
         displayLabel.ForeColor = Color.Black; // change color to black 
      } // end method blackRadioButton_CheckedChanged

      // event handler for Red RadioButton
      private void redRadioButton_CheckedChanged(
         object sender, EventArgs e )
      {
         displayLabel.ForeColor = Color.Red; // change color to red
      } // end method redRadioButton_CheckedChanged

      // event handler for Green RadioButton
      private void greenRadioButton_CheckedChanged(
         object sender, EventArgs e )
      {
         displayLabel.ForeColor = Color.Green; // change color to green
      } // end method greenRadioButton_CheckedChanged

      // event handler for 12 point RadioButton
      private void size12RadioButton_CheckedChanged(
         object sender, EventArgs e )
      {
         // change font size to 12
         displayLabel.Font = new Font( displayLabel.Font.Name, 12 );
      } // end method size12RadioButton_CheckedChanged

      // event handler for 16 point RadioButton
      private void size16RadioButton_CheckedChanged(
         object sender, EventArgs e )
      {
         // change font size to 16
         displayLabel.Font = new Font( displayLabel.Font.Name, 16 );
      } // end method size16RadioButton_CheckedChanged

      // event handler for 20 point RadioButton
      private void size20RadioButton_CheckedChanged(
         object sender, EventArgs e )
      {
         // change font size to 20
         displayLabel.Font = new Font( displayLabel.Font.Name, 20 );
      } // end method size20RadioButton_CheckedChanged

      // event handler for  Hello! RadioButton
      private void helloRadioButton_CheckedChanged(
         object sender, EventArgs e )
      {
         displayLabel.Text = "Hello!"; // change text to Hello!
      } // end method helloRadioButton_CheckedChanged

      // event handler for Goodbye! RadioButton
      private void goodbyeRadioButton_CheckedChanged(
         object sender, EventArgs e )
      {
         displayLabel.Text = "Goodbye!"; // change text to Goodbye!
      } // end method goodbyeRadioButton_CheckedChanged
   } // end class UsingTabsForm
} // end namespace UsingTabs

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
