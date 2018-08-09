using LoginApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.ViewModel
{
    public class CustomerViewModel:INotifyPropertyChanged
    {
        private Customer customer = new Customer();
        public string TxtCustomerName
        {
            get { return customer.Name; }
            set {
                customer.Name = value;
                //OnPropertyRaised("TxtCustomerName");
                OnPropertyRaised("IsLoginEnabled");
            }
        }
        public string TxtCustomerPassword
        {
            get
            {
                return customer.Password;
            }
            set {

                customer.Password = value;
                //OnPropertyRaised("TxtCustomerPassword");
                OnPropertyRaised("IsLoginEnabled");
            }
        }

        public bool IsLoginEnabled
        {
            get
            {
                if (TxtCustomerName == null || TxtCustomerPassword == null)
                    return false;
                if (String.IsNullOrEmpty(TxtCustomerName.Trim()) || string.IsNullOrEmpty(TxtCustomerPassword.Trim()))
                    return false;
                else
                    return true;
               
                
            }
            //set
            //{
            //    OnPropertyRaised("IsLoginEnabled");
            //}
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
