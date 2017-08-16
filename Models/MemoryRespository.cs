using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// The class is the data repository. It is a memory representation of the payment data
/// from data.json file.
/// </summary>
namespace BookingApi.Models
{
    public class MemoryRespository : IRepository
    {
        private List<Payment> paymentList;

        public MemoryRespository()
        {
            using (StreamReader file = File.OpenText("Models/Data.json"))
            {
                paymentList = JsonConvert.DeserializeObject<List<Payment>>(file.ReadToEnd(),
                    new Newtonsoft.Json.Converters.IsoDateTimeConverter {DateTimeFormat="yyyy-MM-dd"});
            }
        }

        public Payment this[int id] => paymentList.FirstOrDefault(p=>p.Id==id);

        public IEnumerable<Payment> Payments => paymentList;
   
        public void DeletePayment(int id)
        {
            var payment = paymentList.FirstOrDefault(p => p.Id == id);
            if (payment== null)
            {
                throw new Exception($"payment withe the id '{id}' not found in data store");
            }

            paymentList.Remove(payment);
        } 
    }
}
