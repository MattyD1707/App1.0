using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App1
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }
        public string JobTitle { get; set; }



    }
}
