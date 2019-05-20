// Fig. 9.6: ListCollection.cs
// Generic List collection demonstration.
using System;
using System.Collections.Generic;

public class ListCollection
{
   public static void Main( string[] args )
   {
      // create a new List of strings
      List< string > items = new List< string >(); 

      items.Add( "red" ); // append an item to the List
      items.Insert( 0, "yellow" ); // insert the value at index 0

      // display the colors in the list
      Console.Write( 
         "Display list contents with counter-controlled loop:" ); 
      for ( int i = 0; i < items.Count; i++ )
         Console.Write( " {0}", items[ i ] );

      // display colors using foreach 
      Console.Write( 
         "\nDisplay list contents with foreach statement:" );
      foreach ( var item in items )
         Console.Write( " {0}", item );

      items.Add( "green" ); // add "green" to the end of the List
      items.Add( "yellow" ); // add "yellow" to the end of the List

      // display the List
      Console.Write( "\nList with two new elements:" ); 
      foreach ( var item in items )
         Console.Write( " {0}", item );

      items.Remove( "yellow" ); // remove the first "yellow"

      // display the List
      Console.Write( "\nRemove first instance of yellow:" ); 
      foreach ( var item in items )
         Console.Write( " {0}", item );

      items.RemoveAt( 1 ); // remove item at index 1

      // display the List
      Console.Write( "\nRemove second list element (green):" ); 
      foreach ( var item in items )
         Console.Write( " {0}", item );

      // check if a value is in the List
      Console.WriteLine( "\n\"red\" is {0}in the list",
         items.Contains( "red" ) ? string.Empty : "not " );

      // display number of elements in the List
      Console.WriteLine( "Count: {0}", items.Count );

      // display the capacity of the List
      Console.WriteLine( "Capacity: {0}", items.Capacity );
   } // end Main
} // end class ListCollection

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
