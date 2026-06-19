using System.ComponentModel.DataAnnotations;

namespace HousingDrey.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = "";

        [Required]
        public string Type { get; set; } = "";

        public decimal Price { get; set; }

        public string City { get; set; } = "Douala";

        [Required]
        public string Quarter { get; set; } = "";

        public double Surface { get; set; }

        public int Bedrooms { get; set; }

        public int Bathrooms { get; set; }

        public string Status { get; set; } = "Disponible";

        public string Description { get; set; } = "";

        public string ImageUrl { get; set; } = "";

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}