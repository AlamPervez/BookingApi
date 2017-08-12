using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookingApi.Models;

namespace BookingApi.Controllers
{
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        private readonly IRepository repository = null;

        public PaymentController(IRepository repository)
        {
            this.repository = repository;
        }

        // GET api/payment
        [HttpGet]
        public IEnumerable<Payment> Get()
        {
           
            return repository.Payments;

            //ToDo: Enhance this method to implement pagination and sort logic:
            //If the pageSize and pageIndex parameters are requested, the
            //result set should be sorted by "id" and return the records for that
            //page only.
        }

        
        // GET api/payment/report
        [HttpGet("{currency}")]
        public IEnumerable<Payment> Get(Currency currency)
        {
            throw new NotImplementedException();

            //ToDo: Implement the code to return a payment list for:
            //Top 10 records with highest amount value and amount converted to the requested 
            //currency code (input parameter)
        }


        // POST api/payment
        [HttpPost]
        public Payment Post([FromBody] Payment payment)
        {
            //ToDo: Implement the create payment code instance with validation on all fields
            throw new NotImplementedException();
        }

        // PUT api/payment/5
        [HttpPut]
        public Payment Put([FromBody]Payment payment)
        {
            //ToDo: Implement the update payment code with validation on all fields
            throw new NotImplementedException();
        }

    //ToDo: Implement the Web API method to delete a payment record.
       
    }

}
