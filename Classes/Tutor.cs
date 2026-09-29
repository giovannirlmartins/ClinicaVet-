using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicaVeterinaria
{
    public class Tutor 
    {
        public string? nome { get; set; }
        public string? telefone { get; set; }
        public string? email { get; set; }
        public string? cpf { get; set; }
        List<Animal> ListaAnimais = new List<Animal>();

        //public Tutor(string ctCpf, string ctNome, string ctTelefone, string ctEmail) : base (ctNome,ctTelefone, ctEmail)
        //{
        //    cpf = ctCpf;
        //    nome = ctNome;
        //    telefone = ctTelefone;
        //    email = ctEmail;
        //}

        public void CadastrarTutor(Tutor tutor)
        {
            
        }

    }
}
