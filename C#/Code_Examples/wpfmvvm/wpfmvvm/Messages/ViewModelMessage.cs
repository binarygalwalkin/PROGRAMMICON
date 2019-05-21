using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Messaging;

namespace wpfmvvm.Messages
{
    class ViewModelMessage: MessageBase
    {
        public string Text { get; set; }
    }
}
