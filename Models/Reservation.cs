using System.ComponentModel.DataAnnotations;

namespace HousingDrey.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public int PropertyId { get; set; }
        public Property? Property { get; set; }

        [Required]
        public string FullName { get; set; } = "";

        [Required]
        public string Phone { get; set; } = "";

        public string Email { get; set; } = "";

        [Required]
        public DateTime VisitDate { get; set; }

        public string Message { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Pending";
    }
}