using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SchroniskoWebowka.Models
{
	public class ZdjeciePsaViewModel
	{
        public decimal Id { get; set; }
        [BindProperty]
        public IFormFile ImageData { get; set; }
    }
}
