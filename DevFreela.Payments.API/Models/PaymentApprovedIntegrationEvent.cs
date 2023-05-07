namespace DevFreela.Payments.API.Models
{
    public class PaymentApprovedIntegrationEvent
    {
        public PaymentApprovedIntegrationEvent(int idProject) =>  idProject = IdProject;

        public int IdProject { get; set; } 

    }
}