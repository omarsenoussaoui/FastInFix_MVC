using JobPortal.Data.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class CreateCVViewModel
    {
        [Display(Name = "Certificat")]
        //[Required(ErrorMessage = "Please enter your certificate")]
        [StringLength(100, ErrorMessage = "Your certificate cannot be more than 100 characters.")]
        public string Certificate { get; set; }
        [Display(Name = "Specialité")]
        //[Required(ErrorMessage = "Please enter your major")]
        [StringLength(100, ErrorMessage = "Your major cannot be more than 50 characters.")]
        public string Major { get; set; }
        [Display(Name = "Diplômé à")]
        //[Required(ErrorMessage = "Please enter where you graduated")]
        [StringLength(100, ErrorMessage = "Your place cannot be more than 50 characters.")]
        public string GraduatedAt { get; set; }
        [Display(Name = "Votre moyenne générale")]
        //[Required(ErrorMessage = "Please enter your GPA")]
        [Range(0, 4, ErrorMessage = "Please enter valid GPA .")]
        public float GPA { get; set; }
        [Display(Name = "Description")]
        // [Required(ErrorMessage = "Please enter your description")]
        public string Description { get; set; }
        [Display(Name = "Introduire")]
        [Required(ErrorMessage = "Please enter your introduce")]
        public string Introduce { get; set; }
        [Display(Name = "CV image")]
        public IFormFile UrlImage { get; set; }
        [Display(Name = "Tlp")]
        //[Required(ErrorMessage = "Please enter your phone")]
        [StringLength(20, ErrorMessage = "Please enter valid phonenumber.", MinimumLength = 9)]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your email")]
        [StringLength(50, ErrorMessage = "Your email cannot be more than 50 characters.")]
        public string Email { get; set; }
	}
}
