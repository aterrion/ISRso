using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace ISRso.Model
{
    class Book : INotifyPropertyChanged
    {
        #region Private
        private int id;
        private string name;
        private int causeNum;
        private int bookVol;
        private int secLvlId;
        private string year;
        private int totalSheets;
        private int organizationId;
        private bool isClosed;
        private bool isArhived;
        private bool isDeleted;
        private DateTime createDate;
        private DateTime editDate;
        private int editUser;
        private DateTime openDate;
        private DateTime closeDate;
        private int closedUser;
        private string numberJournalJournals;
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
        public int CauseNum
        {
            get { return causeNum; }
            set {
                causeNum = value;
                OnPropertyChanged("CauseNum");
            }
        }
        public int BookVol
        {
            get { return bookVol; }
            set {
                bookVol = value;
                OnPropertyChanged("BookVol");
            }
        }
        public int SecLvlId
        {
            get { return secLvlId; }
            set {
                secLvlId = value;
                OnPropertyChanged("SecLvlId");
            }
        }
        public string Year
        {
            get { return year; }
            set {
                year = value;
                OnPropertyChanged("Year");
            }
        }
        public int TotalSheets
        {
            get { return totalSheets; }
            set {
                totalSheets = value;
                OnPropertyChanged("TotalSheets");
            }
        }
        public int OrganizationId
        {
            get { return organizationId; }
            set {
                organizationId = value;
                OnPropertyChanged("OrganizationId");
            }
        }
        public bool IsClosed
        {
            get { return isClosed; }
            set {
                isClosed = value;
                OnPropertyChanged("IsClosed");
            }
        }
        public bool IsArhived
        {
            get { return isArhived; }
            set {
                isArhived = value;
                OnPropertyChanged("IsArhived");
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
        public DateTime CreateDate
        {
            get { return createDate; }
            set {
                createDate = value;
                OnPropertyChanged("CreateDate");
            }
        }
        public DateTime EditDate
        {
            get { return editDate; }
            set
            {
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
        public DateTime OpenDate
        {
            get { return openDate; }
            set
            {
                openDate = value;
                OnPropertyChanged("OpenDate");
            }
        }
        public DateTime CloseDate
        {
            get { return closeDate; }
            set
            {
                closeDate = value;
                OnPropertyChanged("CreateDate");
            }
        }
        public int ClosedUser
        {
            get { return closedUser; }
            set {
                closedUser = value;
                OnPropertyChanged("ClosedUser");
            }
        }
        public string NumberJournalJournals
        {
            get { return numberJournalJournals; }
            set {
                numberJournalJournals = value;
                OnPropertyChanged("NumberJournalJournals");
            }
        }


        #endregion

        Book()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
