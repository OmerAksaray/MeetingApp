
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models{


public class UserInfo
    {   
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad alanı zorunludur!")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Telefon numarası alanı zorunludur!")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="E-mail alanı zorunludur!")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Seöenek bekirtmek zorunludur!")]
        public bool? WillAttend { get; set; }
    }

}