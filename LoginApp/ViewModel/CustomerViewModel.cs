using LoginApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.ViewModel
{
    public class CustomerViewModel:BaseViewModel
    {
        private Customer _customer;
        public CustomerViewModel()
        {
            _customer = new Customer();
        }
        public string CustomerName
        {
            get
            {
                return _customer.Name;
            }
            set
            {
                _customer.Name = value;
                OnPropertyRaised("IsLoginEnabled");
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
                _customer.Password = value;
                OnPropertyRaised("IsLoginEnabled");
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
    }
}
