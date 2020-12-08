using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using System.IO;

namespace MPS_Assignment_8
{
    public partial class MainPage : ContentPage
    {
      
        private CustomerOrder _order;
       
        public MainPage()
        {
            InitializeComponent();
            CustomerOrder Order = new CustomerOrder();
            string text = ordername.Text;

        }

        private void AddDetails_Button_Clicked(object sender, EventArgs e)
        {
           CustomerOrder.order = new OrderDetails();
            object name = OrderDetails.CustomerOrder(ordername, DateTime.Now, "Add Details");
        }

        private void GetCustomerDetails_Button_Clicked(object sender, EventArgs e)
        {

        }
    }
 }



     
       
     
    
   
