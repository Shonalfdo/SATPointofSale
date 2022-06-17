using System;
using System.Collections.Generic;
using System.Text;
using SATPOS.Model;

namespace SATPOS.ViewModel
{
    class InvoiceDataLoader
    {
        private List<Product> LoadProductEntry()
        {
            List<Product> product = new List<Product>();
            product.Add(new Product()
            {
                Prd_ID = 000001,
            });





            return product;
        }
    }
}
