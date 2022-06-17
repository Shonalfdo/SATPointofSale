using System;
using System.Collections.Generic;
using System.Text;

namespace SATPOS.Model
{
    public class Bill
    {
        public int    BillNo        { get; set; }    
        public string BillDate      { get; set; }    
        public int    BillDiscount  { get; set; }    
        public double Quantity      { get; set; }
        public string BillType      { get; set; }
    }
}
