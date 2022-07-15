using System;
using System.Collections.Generic;
using System.Text;

namespace SATPOS.Model
{
    public class Product
    {
        public int    Prd_ID        { get; set; }
        public double ItemCode      { get; set; }
        public string Prd_Name      { get; set; }    
        public int    Prd_Price     { get; set; }    
        public string Prd_Type      { get; set; }
    }
}
