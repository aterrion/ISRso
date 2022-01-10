using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ISRso.Model
{
    class ErdrArhive : INotifyPropertyChanged
    {
        #region Private
        private int id;
        private string number;
        private string judje;
        private string causeNum;
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
        public string Number
        {
            get { return number; }
            set {
                number = value;
                OnPropertyChanged("Number");
            }
        }
        public string Judje
        {
            get { return judje; }
            set {
                judje = value;
                OnPropertyChanged("Judje");
            }
        }
        public string CauseNum
        {
            get { return causeNum; }
            set {
                causeNum = value;
                OnPropertyChanged("CauseNum");
            }
        }

        #endregion

        ErdrArhive()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
