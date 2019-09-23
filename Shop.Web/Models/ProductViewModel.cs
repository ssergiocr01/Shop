namespace Shop.Web.Models
{
    using Data.Entities;
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel : Product
    {
        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }
    }
}
