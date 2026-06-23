using System.ComponentModel.DataAnnotations;

namespace LOGINN.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo no es válido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        // ¡Esta es la propiedad que te faltaba y que arreglará la vista!
        public bool RememberMe { get; set; }
    }
}