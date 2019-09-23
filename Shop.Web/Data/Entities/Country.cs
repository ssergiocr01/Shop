namespace Shop.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Country : IEntity
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} solo puede contener {1} caracteres de longitud.")]
        [Required]
        [Display(Name = "País")]
        public string Name { get; set; }
    }
}
