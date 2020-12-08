using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;


namespace MPS_Assignment_8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CustomerOrder Order = new CustomerOrder();
            string text = ordername.Text;

        }

        private void PlaceYourOrder_Button_Clicked(object sender, EventArgs e)
        {

        }

        private void GetCustomerDetails_Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}

  
       
     
    
   
