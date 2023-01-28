using DevFreela.Payments.API.Models;
using System.Threading.Tasks;

namespace DevFreela.Payments.API.Services
{
    public class PaymentServices : IPaymentsService
    {
        public Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel)
        {
           return Task.FromResult(true);
        }
    }
}
