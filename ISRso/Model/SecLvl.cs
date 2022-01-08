using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ISRso.Model
{
    class SecLvl : INotifyPropertyChanged
    {
        #region Private
        private int id;
        private string name;
        private string fullName;
        #endregion
                          
        #region Propertys
        public int Id
        {
            get { return id; }
            set {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get { return name; }
            set {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string FullName
        {
            get { return fullName; }
            set {
                fullName = value;
                OnPropertyChanged("FullName");
            }
        }
        #endregion

        public SecLvl()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
