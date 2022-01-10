using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ISRso.Model
{
    class DocInBook : INotifyPropertyChanged
    {
        #region Private
        private int id;
        private int documentId;
        private int bookId;
        private int order;
        private string page;
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
        public int DocumentId
        {
            get { return documentId; }
            set {
                documentId = value;
                OnPropertyChanged("DocumentId");
            }
        }
        public int BookId
        {
            get { return bookId; }
            set {
                bookId = value;
                OnPropertyChanged("BookId");
            }
        }
        public int Order
        {
            get { return order; }
            set {
                order = value;
                OnPropertyChanged("Order");
            }
        }
        public string Page
        {
            get { return page; }
            set {
                page = value;
                OnPropertyChanged("Page");
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
        
        DocInBook()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
