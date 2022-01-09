using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ISRso.Model
{
    class D3Cause : INotifyPropertyChanged
    {
        #region Private
        private int id;
        private string causeNum ;
        private string procNum;
        private string causeCore;
        private int d3ID;
        private int d3DBID;
        private int erdrId;
        private int judjeId;
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
        public string CauseNum 
        {
            get { return causeNum; }
            set {
                causeNum = value;
                OnPropertyChanged("CauseNum");
            }
        }
        public string ProcNum
        {
            get { return procNum; }
            set {
                procNum = value;
                OnPropertyChanged("ProcNum");
            }
        }
        public string CauseCore
        {
            get { return causeCore; }
            set {
                causeCore = value;
                OnPropertyChanged("CauseCore");
            }
        }
        public int D3ID
        {
            get { return d3ID; }
            set {
                d3ID = value;
                OnPropertyChanged("D3ID");
            }
        }
        public int D3DBID
        {
            get { return d3DBID; }
            set {
                d3DBID = value;
                OnPropertyChanged("D3DBID");
            }
        }
        public int ErdrId
        {
            get { return erdrId; }
            set {
                erdrId = value;
                OnPropertyChanged("ErdrId");
            }
        }
        public int JudjeId
        {
            get { return judjeId; }
            set {
                judjeId = value;
                OnPropertyChanged("JudjeId");
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


        public D3Cause()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
