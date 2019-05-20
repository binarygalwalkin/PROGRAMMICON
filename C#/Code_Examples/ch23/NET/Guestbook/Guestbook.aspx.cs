// Fig. 23.36: Guestbook.aspx.cs
// Code-behind file that defines event handlers for the guestbook.
using System;

public partial class Guestbook : System.Web.UI.Page
{
   // Submit Button adds a new guestbook entry to the database,
   // clears the form and displays the updated list of guestbook entries
   protected void submitButton_Click( object sender, EventArgs e )
   {
      // use GuestbookEntities DbContext to add a new message 
      using ( GuestbookEntities dbcontext = new GuestbookEntities() )
      {
         // create a new Message to add to the database; Message is
         // the entity data model class representing a table row
         Message message = new Message(); 

         // set new Message's properties
         message.Date = DateTime.Now.ToShortDateString();
         message.Name = nameTextBox.Text;
         message.Email = emailTextBox.Text;
         message.Message1 = messageTextBox.Text;

         // add new Message to GuestbookEntities DbContext
         dbcontext.Messages.Add( message ); 
         dbcontext.SaveChanges(); // save changes to the database
      } // end using statement

      // clear the TextBoxes
      nameTextBox.Text = String.Empty;
      emailTextBox.Text = String.Empty;
      messageTextBox.Text = String.Empty;

      // update the GridView with the new database table contents
      messagesGridView.DataBind();
   } // submitButton_Click

   // Clear Button clears the Web Form's TextBoxes
   protected void clearButton_Click( object sender, EventArgs e )
   {
      nameTextBox.Text = String.Empty;
      emailTextBox.Text = String.Empty;
      messageTextBox.Text = String.Empty;
   } // clearButton_Click
} // end class Guestbook

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