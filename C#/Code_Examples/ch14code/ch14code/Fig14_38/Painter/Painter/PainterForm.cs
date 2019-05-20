// Fig 14.38: PainterForm.cs
// Using the mouse to draw on a Form.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Painter
{
   // creates a Form that is a drawing surface
   public partial class PainterForm : Form
   {
      bool shouldPaint = false; // determines whether to paint

      // default constructor
      public PainterForm()
      {
         InitializeComponent();
      } // end constructor

      // should paint when mouse button is pressed down
      private void PainterForm_MouseDown( 
         object sender, MouseEventArgs e )
      {
         // indicate that user is dragging the mouse
         shouldPaint = true;
      } // end method Painter_MouseDown

      // stop painting when mouse button is released
      private void PainterForm_MouseUp( object sender, MouseEventArgs e )
      {
         // indicate that user released the mouse button
         shouldPaint = false;
      } // end method Painter_MouseUp

      // draw circle whenever mouse moves with its button held down        
      private void PainterForm_MouseMove( 
         object sender, MouseEventArgs e )
      {
         if ( shouldPaint ) // check if mouse button is being pressed
         {
            // draw a circle where the mouse pointer is present
            using ( Graphics graphics = CreateGraphics() )
            {
               graphics.FillEllipse(
                  new SolidBrush( Color.BlueViolet ), e.X, e.Y, 4, 4 );
            } // end using; calls graphics.Dispose()
         } // end if
      } // end method Painter_MouseMove
   } // end class PainterForm
} // end namespace Painter

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