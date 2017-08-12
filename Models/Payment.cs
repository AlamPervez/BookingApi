using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

/// <summary>
/// Entity to describe the payments for the booking system.
/// </summary>
namespace BookingApi.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string User { get; set; }
        public decimal Amount { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Currency Currency { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
