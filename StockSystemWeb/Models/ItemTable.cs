using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockSystemWeb.Models
{
    public class ItemTable
    {
        public int ItemID { get; set; }

        public string ItemName { get; set; }

        public string ItemCode { get; set; }

        public decimal Qty { get; set; }

        public decimal SalePrice { get; set; }

        public decimal BuyPrice { get; set; }

        public UserTable UserID { get; set; }

        public bool Exist { get; set; }
    }
}
