using DevFreela.Payments.API.Models;
using DevFreela.Payments.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DevFreela.Payments.API.Controllers
{
    [Route("api/payments")]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentsService _paymentsService;

        public PaymentController(IPaymentsService paymentsService)
        {
            _paymentsService = paymentsService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentInfoInputModel paymentInfoInputModel)
        {
            var result = await _paymentsService.Process(paymentInfoInputModel);

            if (!result) { return BadRequest(); }

            return NoContent();
        }
    }
}
