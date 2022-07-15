using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using SATPOS.Model;

namespace SATPOS.ViewModel
{
    class BillingLister
    {
        List<Invoice> NewBill = new List<Invoice>();

        public void LoadEntryData(int B_Id, int B_Code, int Quant, int U_Price, int B_Add, int B_Sub, int SubTot)
        {

            NewBill.Add(new Invoice()
            {
                Id = B_Id,
                ItemCode = B_Code,
                Quantity = Quant,
                UnitPrice = U_Price,
                Additions = B_Add,
                Discount = B_Sub,
                SubTotal = SubTot,

            });


        }

        public void WriteToJson()
        {
            string fileName = "WeatherForecast.json";
            string jsonString = JsonSerializer.Serialize(NewBill);
            File.WriteAllText(fileName, jsonString);
        }

        public List<Invoice> SetEntryData()
        {
            return NewBill;
        }
    }
}
