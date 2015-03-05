using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuarios
    {
    }

    public class UsuarioMetadado
    {

        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Login")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Email")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Senha")]
        [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
        public string Senha { get; set; }

    }
}