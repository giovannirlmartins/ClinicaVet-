using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace ClinicaVeterinariaForms.Classes
{
    public class Conexao
    {
        private string dadosConexao = "server=localhost;database=clinica_veterinaria;uid=root;pwd=;";

        public MySqlConnection Conectar()
        {
            MySqlConnection conexao =
                new MySqlConnection(dadosConexao);

            conexao.Open();
            return conexao;
        }
        

    }
}
