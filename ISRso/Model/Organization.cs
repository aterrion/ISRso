using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ISRso.Model
{
    class Organization : INotifyPropertyChanged
    {
        #region Private
        private int id;
        private string name;
        private int cause;
        private string nameRod;
        private string nameDav;
        private string address;
        private string region;
        private string tel;

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
        public int  Cause   
        {
            get { return cause; }
            set {
                cause = value;
                OnPropertyChanged("Cause");
            }
        }
        public string NameRod
        {
            get { return nameRod; }
            set {
                nameRod = value;
                OnPropertyChanged("NameRod");
            }
        }
        public string NameDav
        {
            get { return nameDav; }
            set {
                nameDav = value;
                OnPropertyChanged("NameDav");
            }
        }
        public string Address
        {
            get { return address; }
            set {
                address = value;
                OnPropertyChanged("Address");
            }
        }
        public string Region
        {
            get { return region; }
            set {
                region = value;
                OnPropertyChanged("Region");
            }
        }
        public string Tel
        {
            get { return tel; }
            set {
                tel = value;
                OnPropertyChanged("Tel");
            }
        }

        #endregion

        public Organization()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
