using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinariaForms.Classes
{
    public class Usuario
    {
        //nome, telefone, cpf, estado e senha
        public string? nome { get; set; }
        public string? telefone { get; set; }
        public string? cpf {  get; set; }
        public string? estado { get; set; }
        public string? senha { get; set; }

        public List<Usuario> ListaUsuarios = new List<Usuario>(); 

        public void CadastrarUsuario(Usuario usuario)
        {

        }
    }
}
