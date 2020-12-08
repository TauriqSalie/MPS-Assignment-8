using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;


namespace MPS_Assignment_8
{
    
   public class CustomerOrder
    {
        private SQLiteConnection _database;

        public CustomerOrder()
        {
            var path = GetDbPath();
            _database = new SQLiteConnection(path);
        
            _database.CreateTable<OrderDetails>();
            
        }

        
        public string GetDbPath()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "order.db");
            return path;
        }
        
        public string AddDetails()
        {
            var p = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "order.db");
            return path;
        }
    }
}
