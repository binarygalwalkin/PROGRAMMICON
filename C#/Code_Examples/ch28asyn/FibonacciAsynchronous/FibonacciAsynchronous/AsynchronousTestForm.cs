// Fig. 28.3: AsynchronousTestForm.cs
// Fibonacci calculations performed in separate threads
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciAsynchronous
{
   public partial class AsynchronousTestForm : Form
   {
      public AsynchronousTestForm()
      {
         InitializeComponent();
      } // end constructor

      // start asynchronous calls to Fibonacci
      private async void startButton_Click( object sender, EventArgs e )
      {
         outputTextBox.Text = 
            "Starting Task to calculate Fibonacci(46)\r\n";

         // create Task to perform Fibonacci(46) calculation in a thread
         Task< TimeData > task1 =
            Task.Run( () => StartFibonacci( 46 ) );

         outputTextBox.AppendText(
            "Starting Task to calculate Fibonacci(45)\r\n" );
            
         // create Task to perform Fibonacci(45) calculation in a thread
         Task< TimeData > task2 =
            Task.Run( () => StartFibonacci( 45 ) );
         
         await Task.WhenAll( task1, task2 ); // wait for both to complete

         // determine time that first thread started
         DateTime startTime = 
            ( task1.Result.StartTime < task2.Result.StartTime ) ? 
            task1.Result.StartTime : task2.Result.StartTime;

         // determine time that last thread ended
         DateTime endTime = 
            ( task1.Result.EndTime > task2.Result.EndTime ) ? 
            task1.Result.EndTime : task2.Result.EndTime;

         // display total time for calculations
         outputTextBox.AppendText( String.Format(
            "Total calculation time = {0:F6} minutes\r\n",
            endTime.Subtract( startTime ).TotalMilliseconds / 
            60000.0 ) );
      } // end method startButton_Click

      // starts a call to fibonacci and captures start/end times
      TimeData StartFibonacci( int n )
      {
         // create a ThreadData object to store start/end times
         TimeData result = new TimeData();

         AppendText( String.Format( "Calculating Fibonacci({0})", n ) );
         result.StartTime = DateTime.Now; // time before calculation
         long fibonacciValue = Fibonacci( n ); 
         result.EndTime = DateTime.Now; // time after calculation

         AppendText( String.Format( "Fibonacci({0}) = {1}", 
            n, fibonacciValue ) );
         AppendText( String.Format( 
            "Calculation time = {0:F6} minutes\r\n",
            result.EndTime.Subtract(
               result.StartTime ).TotalMilliseconds / 60000.0 ) );

         return result;
      } // end method StartFibonacci

      // Recursively calculates Fibonacci numbers
      public long Fibonacci( long n )
      {
         if ( n == 0 || n == 1 )
            return n;
         else
            return Fibonacci( n - 1 ) + Fibonacci( n - 2 );
      } // end method Fibonacci

      // append text to outputTextBox in UI thread
      public void AppendText( String text )
      {
         if ( InvokeRequired ) // not GUI thread, so add to GUI thread
            Invoke( new MethodInvoker( () => AppendText( text ) ) );
         else // GUI thread so append text
            outputTextBox.AppendText( text + "\r\n" );
      } // end method AppendText
   } // end class AsynchronousTestForm
} // end namespace FibonacciAsynchronous

/*************************************************************************
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
