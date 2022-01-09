using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ISRso.Model 
{
    class ErdrNum : INotifyPropertyChanged
    {
        #region Private
        private int id;
        private string number;
        private DateTime createDate;
        private int createUser;
        private DateTime editDate;
        private int editUser;
        private int version;
        private bool isDeleted;

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
        public string _code { get; private set; }
        public string _year { get; private set; }
        public string _orgcode { get; private set; }
        public string _org { get; private set; }
        public string _num { get; private set; }
        public DateTime CreateDate
        {
            get { return createDate; }
            set {
                createDate = value;
                OnPropertyChanged("Createdate");
            }
        }
        public int CreateUser
        {
            get { return createUser; }
            set {
                createUser = value;
                OnPropertyChanged("CreateUser");
            }
        }
        public DateTime EditDate
        {
            get { return editDate; }
            set {
                editDate = value;
                OnPropertyChanged("EditDate");
            }
        }
        public int EditUser
        {
            get { return editUser; }
            set {
                editUser = value;
                OnPropertyChanged("EditUser");
            }
        }
        public int Version
        {
            get { return version; }
            set {
                version = value;
                OnPropertyChanged("Version");
            }
        }
        public bool IsDeleted
        {
            get { return isDeleted; }
            set {
                isDeleted = value;
                OnPropertyChanged("IsDeleted");
            }
        }

        #endregion


        public ErdrNum()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
