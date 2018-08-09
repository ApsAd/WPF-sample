using LoginApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LoginApp.ViewModel
{
    public class CustomerViewModel:BaseViewModel
    {
        private Customer _customer;
        public CustomerViewModel()
        {
            _customer = new Customer();
            LoginCommand = new RelayCommand(SayHello);
        }
        public string CustomerName
        {
            get
            {
                return _customer.Name;
            }
            set
            {
               if (_customer.Name != value)
                {   _customer.Name = value;
                    OnPropertyRaised("CustomerName");
                    OnPropertyRaised("IsLoginEnabled");
                }
            }
        }
        public string CustomerPassword
        {
            get
            {
                return _customer.Password;
            }
            set
            {
                if (_customer.Password != value)
                {
                    _customer.Password = value;
                    OnPropertyRaised("CustomerPassword");
                    OnPropertyRaised("IsLoginEnabled");
                }
            }
        }
        public bool IsLoginEnabled
        {
            get
            {
                if (CustomerName == null || CustomerPassword == null)
                    return false;
                if (String.IsNullOrEmpty(CustomerName.Trim()) || string.IsNullOrEmpty(CustomerPassword.Trim()))
                    return false;
                else
                    return true;
               
            }           
        }
        public ICommand LoginCommand { get; set; }
        public void SayHello(Object parameter)
        {
            CustomerName = CustomerName.Trim();
            CustomerPassword = CustomerPassword.Trim();
            MessageBox.Show("Hello " + CustomerName+"xx");
        }
    }
}
