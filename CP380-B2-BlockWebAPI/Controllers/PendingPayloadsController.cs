using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP380_B2_BlockWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PendingPayloadsController : ControllerBase
    {
        // TODO
        public class PendingPayloadsController : ControllerBase
        {
            private Pendingpayloadcontrollerbase payloadpending;

            public PendingPayloadsController(Pendingpayloadcontrollerbase payloadpending)
            {
                payloadpending = payloadpending;
            }

            [HttpGet]                                   //retrieves a list of all transactions currently stored by the server
            public ActionResult<List<Payload>> Get()
            {

                return (payloadpending);
            }
            [HttpPost]                              //add a new transaction to the list of pending payloads
            public ActionResult<Payload> Post(Payload data)
            {
                payloadpending.payloadpending();
                return (payloadpending);
            }
        }
    }
}

        
