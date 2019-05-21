// Fig. 14.28: RadioButtonTestForm.cs
// Using RadioButtons to set message window options.
using System;
using System.Windows.Forms;

namespace RadioButtonTest
{
   // Form contains several RadioButtons--user chooses one
   // from each group to create a custom MessageBox
   public partial class RadioButtonTestForm : Form
   {
      // create variables that store the user's choice of options
      private MessageBoxIcon iconType;
      private MessageBoxButtons buttonType;

      // default constructor
      public RadioButtonTestForm()
      {
         InitializeComponent();
      } // end constructor

      // change Buttons based on option chosen by sender
      private void buttonType_CheckedChanged( 
         object sender, EventArgs e )
      {
         if ( sender == okRadioButton ) // display OK Button
            buttonType = MessageBoxButtons.OK;

         // display OK and Cancel Buttons
         else if ( sender == okCancelRadioButton )
            buttonType = MessageBoxButtons.OKCancel;

         // display Abort, Retry and Ignore Buttons
         else if ( sender == abortRetryIgnoreRadioButton )
            buttonType = MessageBoxButtons.AbortRetryIgnore;

         // display Yes, No and Cancel Buttons
         else if ( sender == yesNoCancelRadioButton )
            buttonType = MessageBoxButtons.YesNoCancel;

         // display Yes and No Buttons
         else if ( sender == yesNoRadioButton )
            buttonType = MessageBoxButtons.YesNo;

         // only one option left--display Retry and Cancel Buttons
         else
            buttonType = MessageBoxButtons.RetryCancel;
      } // end method buttonType_Changed

      // change Icon based on option chosen by sender
      private void iconType_CheckedChanged( object sender, EventArgs e )
      {
         if ( sender == asteriskRadioButton ) // display asterisk Icon
            iconType = MessageBoxIcon.Asterisk;

         // display error Icon
         else if ( sender == errorRadioButton )
            iconType = MessageBoxIcon.Error;

         // display exclamation point Icon
         else if ( sender == exclamationRadioButton )
            iconType = MessageBoxIcon.Exclamation;

         // display hand Icon
         else if ( sender == handRadioButton )
            iconType = MessageBoxIcon.Hand;

         // display information Icon
         else if ( sender == informationRadioButton )
            iconType = MessageBoxIcon.Information;

         // display question mark Icon
         else if ( sender == questionRadioButton )
            iconType = MessageBoxIcon.Question;

         // display stop Icon
         else if ( sender == stopRadioButton )
            iconType = MessageBoxIcon.Stop;

         // only one option left--display warning Icon
         else
            iconType = MessageBoxIcon.Warning;
      } // end method iconType_CheckChanged

      // display MessageBox and Button user pressed
      private void displayButton_Click( object sender, EventArgs e )
      {
         // display MessageBox and store
         // the value of the Button that was pressed
         DialogResult result = MessageBox.Show(
            "This is your Custom MessageBox.", "Custom MessageBox",
            buttonType, iconType);

         // check to see which Button was pressed in the MessageBox
         // change text displayed accordingly
         switch ( result )
         {
            case DialogResult.OK:
               displayLabel.Text = "OK was pressed.";
               break;
            case DialogResult.Cancel:
               displayLabel.Text = "Cancel was pressed.";
               break;
            case DialogResult.Abort:
               displayLabel.Text = "Abort was pressed.";
               break;
            case DialogResult.Retry:
               displayLabel.Text = "Retry was pressed.";
               break;
            case DialogResult.Ignore:
               displayLabel.Text = "Ignore was pressed.";
               break;
            case DialogResult.Yes:
               displayLabel.Text = "Yes was pressed.";
               break;
            case DialogResult.No:
               displayLabel.Text = "No was pressed.";
               break;
         } // end switch
      } // end method displayButton_Click
   } // end class RadioButtonsTestForm
} // end namespace RadioButtonsTest

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
