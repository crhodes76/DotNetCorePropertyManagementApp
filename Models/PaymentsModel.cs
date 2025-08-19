namespace DotNetCorePropertyManagementApp.Models
{
    public class PaymentModel
    {
        public PaymentModel()
        {

        }
        public string PaymentId { get; set; } = string.Empty;
        public string PropertyId { get; set; } = string.Empty;
        public string TenantId { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 0.0m;
        public DateTime PaymentDate { get; set; } = DateTime.MinValue;
        public string PaymentMethod { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public DateTime DateLogged { get; set; } = DateTime.UtcNow;
    }
}