using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Ay.Framework.WPF
{
    public class AyPagingDto<T> : AyPropertyChanged
    {
        public AyPagingDto()
        {
            Data = new ObservableCollection<T>();
        }

        private ObservableCollection<T> _data;
        public ObservableCollection<T> Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
                OnPropertyChanged("Data");
            }
        }

        public int _total;
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                if (_total != value)
                {
                    _total = value;
                    OnPropertyChanged("Total");
                }
            }
        }

    }
}
