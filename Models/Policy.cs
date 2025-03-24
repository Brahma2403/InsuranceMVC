using System.ComponentModel.DataAnnotations;

namespace InsuranceMVC.Models
{
    public class Policy
    {
        [Key]
        public int PolicyId { get; set; }

        [Required(ErrorMessage = "Policy Type is required"), MaxLength(100)]
        public string PolicyType { get; set; }

        [Required(ErrorMessage = " CoverageAmount is required")]
        public double CoverageAmount { get; set; }

        [Required(ErrorMessage = "PremiumAmount is required")]
        public double PremiumAmount { get; set; }

        [Required(ErrorMessage = "ValidityStartDate  is required")]
        public DateOnly ValidityStartDate { get; set; }

        [Required(ErrorMessage = "ValidityEndDate is required")]
        public DateOnly ValidityEndDate { get; set; }

        public virtual ICollection<Claim> Claims { get; set; }
        public virtual ICollection<PremiumCalculation> PremiumCalculations { get; set; }
    }
}
