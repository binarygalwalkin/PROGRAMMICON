using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ItemsControlDataTemplateTest
{
    public class StudentListViewModel
    {
        public ObservableCollection<StudentData> TheStudents { get; private set; }

        public StudentListViewModel()
        {
            TheStudents = new ObservableCollection<StudentData>();
        }
    }
}
