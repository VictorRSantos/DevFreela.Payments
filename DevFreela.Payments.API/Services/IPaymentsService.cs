using DevFreela.Payments.API.Models;
using System.Threading.Tasks;

namespace DevFreela.Payments.API.Services
{
    public interface IPaymentsService
    {
        Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel);
    }
}
