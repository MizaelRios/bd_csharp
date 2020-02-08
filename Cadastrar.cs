using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Cadastrar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();

        public String mensagem;


        public Cadastrar(String nome, String telefone)
        {
            //Comando Sql (SqlCommand)-- insert, update, delete
            cmd.CommandText = "insert into pessoa (nome, telefone) values (@nome, @telefone)";

            //Parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);


            try
            {
                //Conectar com banco -- conexao
                cmd.Connection = conexao.conectar();

                //Executar comando
                cmd.ExecuteNonQuery();

                //Desconectar
                conexao.desconectar();

                //Mostrar mensagem de erro ou sucesso -- variavel
                this.mensagem = "Cadastrado com Sucesso!!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de Dados";
            }

        }




        //Mostrar mensagem de erro ou sucesso

    }
}
