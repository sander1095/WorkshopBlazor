using System.ComponentModel.DataAnnotations;

namespace Class_Library.Models.Customer
{
    public class Customer
    {
        [Required(ErrorMessage = "Naam is verplicht")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Achternaam is verplicht")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Address is verplicht")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Stad is verplicht")]
        public string City { get; set; }
        [Required(ErrorMessage = "Postcode is verplicht")]
        [RegularExpression(pattern: "(NL-)?(\\d{4})\\s*([A-Z]{2})", ErrorMessage = "Postcode is ongeldig")]
        public string PostalCode { get; set; }
    }
}