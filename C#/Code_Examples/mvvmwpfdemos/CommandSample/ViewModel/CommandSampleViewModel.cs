using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CommandSample
{
    public class CommandSampleViewModel
    {
        public DelegateCommand TheCommand { get; private set; }

        public CommandSampleViewModel()
        {
            TheCommand = new DelegateCommand(OnExecute, CanExecute);
        }

        bool CanExecute(object parameter)
        {
            return true;
        }

        void OnExecute()
        {
            MessageBox.Show("Command Executed");
        }
    }
}
