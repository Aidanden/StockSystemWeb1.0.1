﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockSystemWeb.Models
{
    public class UserTable
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool Exist { get; set; }
    }
}
