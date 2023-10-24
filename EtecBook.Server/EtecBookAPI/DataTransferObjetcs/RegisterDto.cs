using System.ComponentModel.DataAnnotations;

namespace EtecBookAPI.DataTransferObjetcs
{
    public class RegisterDto
    {
        [Required(ErrorMessage ="Informe o nome do Usuario")]
        [StringLength(60,ErrorMessage ="O nome deve possuir no maximo 60 caracteres")]
        public string Name { get; set; }
        
        [Required(ErrorMessage ="Informe o nome do Usuario")]
        [EmailAddress(ErrorMessage ="Informa um email valido")]
        [StringLength(100, ErrorMessage ="O email deve possuir no maximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Informe a Senha de acesso")]
        [StringLength(20,MinimumLength =6, ErrorMessage ="A senha deve possuir no minimo 6 caracteres e no maximo 20 caracteres")]
        public string Password { get; set; }
    
    }
}