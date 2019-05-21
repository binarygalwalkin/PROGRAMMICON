using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ItemsControlDataTemplateTest
{
    public class StudentData : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        string _firstName = null;
        public string StudentFirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;

                OnPropertyChanged("StudentFirstName");
            }
        }

        double _gradePointAverage;
        public double StudentGradePointAverage
        {
            get
            {
                return _gradePointAverage;
            }

            set
            {
                _gradePointAverage = value;
                OnPropertyChanged("StudentGradePointAverage");
            }
        }
    }

}
