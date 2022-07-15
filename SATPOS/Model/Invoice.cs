using System;
using System.Collections.Generic;
using System.Text;

namespace SATPOS.Model
{
    class Invoice
    {
        public int    Id        { get; set; }
        public double ItemCode  { get; set; }
        public double ItemName  { get; set; }
        public double Quantity  { get; set; }
        public double UnitPrice { get; set; }
        public double SubTotal  { get; set; }
        public double Discount  { get; set; }
        public double Additions { get; set; }

        public double CreateEntry()
        {
            return 0;
        }

    }
}
