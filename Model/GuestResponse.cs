using System.ComponentModel.DataAnnotations;
namespace C1.Model
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Must be a valid email")]
        public string Email { get;set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [Phone(ErrorMessage = "Must be a valid phone number")]
        public string Phone {  get; set; }
        [Required(ErrorMessage = "Please specify whether you will attend")]
        public bool? WillAttend { get; set; }
    }
}
