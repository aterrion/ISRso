using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ISRso.Model
{
    class DocType : INotifyPropertyChanged
    {
        #region Private
        private int id;
        private string name;
        private int code;

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
        public int Code
        {
            get { return code; }
            set {
                code = value;
                OnPropertyChanged("Code");
            }
        }

        #endregion

        DocType()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
