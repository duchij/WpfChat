using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WpfChat.ChatApp;

namespace WpfChat.WPFDataClasses
{
    public class WPFContact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ContactInfoData _Data;
        private string _Name;

        public WPFContact()
        {
           
        }

        public string Name
        {
            get
            {
                return _Data._NickName;
            }
            set
            {
                this._Name = _Data._NickName;
                OnPropertyChanged("Name");
            }
          
        }

        public UserStateType ContactStateType
        {
            get
            {
                return _Data._ContactStateType;
            }
        }

        public void SetContactData(ContactInfoData pData)
        {
            _Data = pData;
            this.OnPropertyChanged("Name");
            //OnPropertyChanged("ContactStateType");
        }

        private void OnPropertyChanged(string pParam)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            
            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(pParam));
            }
        }
    }
}
