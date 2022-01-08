using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace ISRso.Model
{
    class Document : INotifyPropertyChanged
    {
        #region Private
        private int id;
        private string inNumber;
        private DateTime inDate;
        private string outNumber;
        private DateTime outDate;
        private int organizationId;
        private int secLvlId;
        private int docTypeId;
        private int parentDocId;
        private int atachments;
        private int erdrId;
        private int sheets;
        private string text;
        private int examples;
        private int d3CauseId;
        private int locationId;
        private DateTime createDate;
        private int createUser;
        private DateTime editDate;
        private int editUser;
        private DateTime removeDate;
        private string removeInfo;
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
        public string InNumber
        {
            get { return inNumber; }
            set {
                inNumber = value;
                OnPropertyChanged("InNumber");
            }
        }
        public DateTime InDate
        {
            get { return inDate; }
            set
            {
                inDate = value;
                OnPropertyChanged("InDate");
            }
        }
        public string OutNumber
        {
            get { return outNumber; }
            set {
                outNumber = value;
                OnPropertyChanged("OutNumber");
            }
        }
        public DateTime OutDate
        {
            get { return outDate; }
            set {
                outDate = value;
                OnPropertyChanged("OutDate");
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
        public int SecLvlId
        {
            get { return secLvlId; }
            set {
                secLvlId = value;
                OnPropertyChanged("SecLvlId");
            }
        }
        public int DocTypeId
        {
            get { return docTypeId; }
            set {
                docTypeId = value;
                OnPropertyChanged("DocTypeId");   
            }
        }
        public int ParenrDocId
        {
            get { return parentDocId; }
            set {
                parentDocId = value;
                OnPropertyChanged("ParentDocId");
            }
        }
        public int Attachments
        {
            get { return atachments; }
            set {
                atachments = value;
                OnPropertyChanged("Attachments");
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
        public int Sheets
        {
            get { return sheets; }
            set {
                sheets = value;
                OnPropertyChanged("Sheets");
            }
        }
        public string Text
        {
            get { return text; }
            set {
                text = value;
                OnPropertyChanged("Text");
            }
        }
        public int Examples
        {
            get { return examples; }
            set {
                examples = value;
                OnPropertyChanged("Examples");
            }
        }
        public int D3CauseId
        {
            get { return d3CauseId; }
            set {
                d3CauseId = value;
                OnPropertyChanged("D3CauseId");
            }
        }
        public int LocationId
        {
            get { return locationId; }
            set {
                locationId = value;
                OnPropertyChanged("LocationId");
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
        public DateTime RemoveDate
        {
            get { return removeDate; }
            set {
                removeDate = value;
                OnPropertyChanged("RemoveDate");
            }

        }
        public string RemoveInfo
        {
            get { return removeInfo; }
            set {
                removeInfo = value;
                OnPropertyChanged("RemoveInfo");
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


        Document()
        {

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
