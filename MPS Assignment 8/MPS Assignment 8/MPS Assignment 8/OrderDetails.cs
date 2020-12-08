using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MPS_Assignment_8
{
    class OrderDetails
    {
        public static string Text { get; internal set; }

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string TShirtSize { get; set; }
       public int DateofOrder { get; set; }
       public string TShirtColour { get; set; }
       public string ShippingAddress { get; set; }
        
       

        

        
    }
}
